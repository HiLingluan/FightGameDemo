Shader "Custom/Effects/RimLighting" 
{
    Properties
    {
        _MainTex("Main Tex",2D) = "black"{}
        _MainColor("Main Color", Color) = (0.5,0.5,0.5,1)
        [HDR]_RimColor("rim color",Color) = (1,1,1,1)//边缘颜色
        _RimPower ("rim power",range(1,10)) = 2//边缘强度
        _Transparent ("Transparent",range(0,1)) = 0//边缘强度
    }
 
    SubShader
    {
        Tags { "IgnoreProjector"="True"
                "Queue"="Transparent"
                "RenderType"="Transparent" 
                }
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include"UnityCG.cginc"
 
            struct v2f
            {
                float4 vertex:POSITION;
                float4 uv:TEXCOORD0;
                float4 NdotV:COLOR;
            };
 
            uniform sampler2D _MainTex;
            uniform float4 _MainColor;  
            uniform float4 _RimColor;
            uniform float _RimPower;
            uniform float _Transparent;
 
            v2f vert(appdata_base v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.texcoord;
                float3 V = WorldSpaceViewDir(v.vertex);
                V = mul(unity_WorldToObject,V);//视方向从世界到模型坐标系的转换
                o.NdotV.x = saturate(dot(v.normal,normalize(V)));//必须在同一坐标系才能正确做点乘运算
                return o;
            }
 
            half4 frag(v2f IN):COLOR
            {
                half4 c = tex2D(_MainTex,IN.uv)*_MainColor;
                //用视方向和法线方向做点乘，越边缘的地方，法线和视方向越接近90度，点乘越接近0.
                //用（1- 上面点乘的结果）*颜色，来反映边缘颜色情况
                c.rgb += pow((1-IN.NdotV.x) ,_RimPower)* _RimColor.rgb;
                c.a=1-_Transparent;
                return c;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}