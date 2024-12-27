Effect
{
    Parameter
    {
        Class object, Type sampler
        {
        }
        Name: uImage0
    }
    Parameter
    {
        Class object, Type sampler
        {
        }
        Name: uImage1
    }
    Parameter
    {
        Class object, Type sampler
        {
        }
        Name: uImage2
    }
    Parameter
    {
        Class object, Type sampler
        {
        }
        Name: uImage3
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uColor
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uSecondaryColor
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uScreenResolution
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uScreenPosition
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uTargetPosition
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uDirection
    }
    Parameter
    {
        Class scalar, Type float
        {
        }
        Name: uOpacity
    }
    Parameter
    {
        Class scalar, Type float
        {
        }
        Name: uTime
    }
    Parameter
    {
        Class scalar, Type float
        {
        }
        Name: uIntensity
    }
    Parameter
    {
        Class scalar, Type float
        {
        }
        Name: uProgress
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uImageSize1
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uImageSize2
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uImageSize3
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uImageOffset
    }
    Parameter
    {
        Class scalar, Type float
        {
        }
        Name: uSaturation
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uSourceRect
    }
    Parameter
    {
        Class vector, Type float
        {
        }
        Name: uZoom
    }
    Technique Technique1
    {
        Pass Shockwave
        {
            Class object, Type pixelshader
            {
            }
        }
    }
    Resource for Technique Technique1 Pass Shockwave
    {
        // "CTAB\x1c\x00\x00\x00\xbb\x00\x00\x00\x00\x02\xff\xff\x03\x00\x00\x00\x1c\x00\x00\x00\x00\x00\x00 \xb4\x00\x00\x00X\x00\x00\x00\x02\x00\x05\x00\x01\x00\x00\x00`\x00\x00\x00p\x00\x00\x00\x80\x00\x00\x00\x03\x00\x00\x00\x01\x00\x02\x00\x88\x00\x00\x00\x00\x00\x00\x00\x98\x00\x00\x00\x02\x00\x06\x00\x01\x00"...
        // "PRES\x01\x02XF\xfe\xffX\x00CTAB\x1c\x00\x00\x00+\x01\x00\x00\x01\x02XF\x05\x00\x00\x00\x1c\x00\x00\x00\x00\x01\x00 (\x01\x00\x00\x80\x00\x00\x00\x02\x00\x00\x00\x01\x00\x00\x00\x88\x00\x00\x00\x98\x00\x00\x00\xa8\x00\x00\x00\x02\x00\x04\x00\x01\x00\x00\x00\xb4\x00\x00\x00\x98\x00\x00\x00\xc4\x00\x00\x00"...
        def c7 = 0.000000, 3.141593, 0.159155, 0.500000
        def c8 = 6.283185, -3.141593, -0.000000, -1.000000
        def c9 = -0.000002, -0.000022, 0.002604, 0.000260
        def c10 = -0.020833, -0.125000, 1.000000, 0.500000
        dcl t.xy
        dcl_2d s
        add r.xy, t, -c
        mul r.xy, r, c1
        dp2add r.z, r, r, c7.x
        mul r.z, r.z, c5.y
        mov r.w, c7.y
        mad r.z, r.z, r.w, -c2.x
        add r.w, -r.z, c3.x
        cmp r.w, r.w, c8.z, c8.w
        cmp r.w, r.z, -c7.x, r.w
        mad r.z, r.z, c7.z, c7.w
        frc r.z, r.z
        mad r.z, r.z, c8.x, c8.y
        sincos r1.y, r.z, c9, c10
        mul r.z, r1.y, c6.x
        cmp r.z, r1.y, r.z, c7.x
        cmp r.z, r.w, c7.x, r.z
        mul r.zw, r.z, c4.wzyx
        mad r.xy, r.wzyx, r, t
        texld r, r, s
        mov oC, r
    }
}
