include "../StandardLibrary/StandardLibrary.dfy"
include "../StandardLibrary/UInt.dfy"
include "./AlgorithmSuite.dfy"


module SDKDefs {
    import opened StandardLibrary
    import opened UInt = StandardLibrary.UInt
    import AlgorithmSuite

    type EncCtx = seq<(seq<uint8>, seq<uint8>)>


    const EC_PUBLIC_KEY_FIELD: seq<uint8> := byteseq_of_string("aws-crypto-public-key");

    datatype EDK = EDK(provider_id : seq<uint8>, 
                       provider_info : seq<uint8>, 
                       ciphertext : seq<uint8>)

    datatype EncMaterials = EncMat(alg_id : AlgorithmSuite.ID, 
                                   edks : seq<EDK>, 
                                   enc_ctx : EncCtx, 
                                   data_key : Option<seq<uint8>>, 
                                   signing_key : Option<seq<uint8>>)

    predicate WFEncMaterials(x : EncMaterials) {
        x.data_key.Some? ==> |x.data_key.get| == AlgorithmSuite.input_key_length(x.alg_id)
        // TODO: wf signature
    }

    datatype DecMaterials = DecMat(alg_id : AlgorithmSuite.ID, enc_ctx : EncCtx, data_key : Option<seq<uint8>>, verif_key : Option<seq<uint8>>)

    predicate WFDecMaterials(x : DecMaterials) {
        x.data_key.Some? ==> |x.data_key.get| == AlgorithmSuite.input_key_length(x.alg_id)
    }



    function method naive_merge<T> (x : seq<T>, y : seq<T>, lt : (T, T) -> bool) : seq<T>
    {
        if |x| == 0 then y
        else if |y| == 0 then x 
        else if lt(x[0], y[0]) then [x[0]] + naive_merge(x[1..], y, lt)
        else [y[0]] + naive_merge(x, y[1..], lt)
    }

    function method naive_merge_sort<T> (x : seq<T>, lt : (T, T) -> bool) : seq<T>
    {
        if |x| < 2 then x else
        var t := |x| / 2; naive_merge(naive_merge_sort(x[..t], lt), naive_merge_sort(x[t..], lt), lt)

    }
    
    function method memcmp_le (a : seq<uint8>, b : seq<uint8>, len : nat) : (res : Option<bool>)
        requires |a| >= len
        requires |b| >= len {
        if len == 0 then None else if a[0] != b[0] then Some(a[0] < b[0]) else memcmp_le (a[1..], b[1..], len - 1)
    }

    predicate method lex_lt(b : seq<uint8>, a : seq<uint8>)
    {
        match memcmp_le(a,b, if |a| < |b| then |a| else |b|) {
        case Some(b) => !b
        case None => !(|a| <= |b|)
        }
  }

    predicate method lt_keys(b : (seq<uint8>, seq<uint8>), a : (seq<uint8>, seq<uint8>)) {
        lex_lt(b.0, a.0)
    }

    function method EncCtxFlatten (x : seq<(seq<uint8>, seq<uint8>)>) : seq<uint8> { 
        if x == [] then [] else
        x[0].0 + x[0].1 + EncCtxFlatten(x[1..])
    }

    function method FlattenSortEncCtx(x : seq<(seq<uint8>, seq<uint8>)>) : seq<uint8>
    {
        EncCtxFlatten(naive_merge_sort(x, lt_keys))
    }

    function method enc_ctx_lookup(x : seq<(seq<uint8>, seq<uint8>)>, k : seq<uint8>) : Option<seq<uint8>>
    {
        if |x| == 0 then None else
        if x[0].0 == k then Some(x[0].1) else enc_ctx_lookup(x[1..], k)
    }

    function method enc_ctx_of_strings(x : seq<(string, string)>) : seq<(seq<uint8>, seq<uint8>)>  {
        if x == [] then [] else
        [(byteseq_of_string_lossy(x[0].0), byteseq_of_string_lossy(x[0].1))] + enc_ctx_of_strings(x[1..])
    }
}