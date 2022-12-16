// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
package software.amazon.cryptography.materialProviders.model;

import java.util.Objects;

public class InvalidDecryptionMaterialsTransition extends NativeError {
  protected InvalidDecryptionMaterialsTransition(BuilderImpl builder) {
    super(builder);
  }

  @Override
  public Builder toBuilder() {
    return new BuilderImpl(this);
  }

  public static Builder builder() {
    return new BuilderImpl();
  }

  public interface Builder extends NativeError.Builder {
    Builder message(String message);

    Builder cause(Throwable cause);

    InvalidDecryptionMaterialsTransition build();
  }

  static class BuilderImpl extends NativeError.BuilderImpl implements Builder {
    protected BuilderImpl() {
    }

    protected BuilderImpl(InvalidDecryptionMaterialsTransition model) {
      super(model);
    }

    @Override
    public Builder message(String message) {
      super.message(message);
      return this;
    }

    @Override
    public Builder cause(Throwable cause) {
      super.cause(cause);
      return this;
    }

    @Override
    public InvalidDecryptionMaterialsTransition build() {
      if (Objects.isNull(this.message()))  {
        throw new IllegalArgumentException("Missing value for required field `message`");
      }
      return new InvalidDecryptionMaterialsTransition(this);
    }
  }
}