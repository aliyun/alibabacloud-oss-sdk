package com.aliyun.oss.baseclient.annotation;

import java.lang.annotation.*;

@Documented
@Retention(RetentionPolicy.RUNTIME)
@Target({ElementType.FIELD})
public @interface Encode {
    String encodeType() default "";
}
