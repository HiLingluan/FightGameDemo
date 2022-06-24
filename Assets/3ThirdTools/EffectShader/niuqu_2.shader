// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|alpha-1726-OUT,refract-9423-OUT;n:type:ShaderForge.SFN_Tex2d,id:758,x:32180,y:32946,ptovrint:False,ptlb:node_5859,ptin:_node_5859,varname:node_5859,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:93246ac68c01d0b43b623ac243997b8a,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:8766,x:32128,y:33301,ptovrint:False,ptlb:qiangdu,ptin:_qiangdu,varname:node_3229,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2393162,max:1;n:type:ShaderForge.SFN_Multiply,id:9423,x:32802,y:33118,varname:node_9423,prsc:2|A-6956-OUT,B-8689-A,C-8766-OUT,D-758-A;n:type:ShaderForge.SFN_Vector1,id:1726,x:32455,y:32915,varname:node_1726,prsc:2,v1:0;n:type:ShaderForge.SFN_Append,id:6956,x:32492,y:33030,varname:node_6956,prsc:2|A-758-R,B-758-G;n:type:ShaderForge.SFN_Color,id:8689,x:32324,y:33418,ptovrint:False,ptlb:node_8689,ptin:_node_8689,varname:node_8689,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;proporder:758-8766-8689;pass:END;sub:END;*/

Shader "Shader Forge/niuqu_2" {
    Properties {
        _node_5859 ("node_5859", 2D) = "white" {}
        _qiangdu ("qiangdu", Range(0, 1)) = 0.2393162
        _node_8689 ("node_8689", Color) = (0.5,0.5,0.5,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _node_5859; uniform float4 _node_5859_ST;
            uniform float _qiangdu;
            uniform float4 _node_8689;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 projPos : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeGrabScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 _node_5859_var = tex2D(_node_5859,TRANSFORM_TEX(i.uv0, _node_5859));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (float2(_node_5859_var.r,_node_5859_var.g)*_node_8689.a*_qiangdu*_node_5859_var.a);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
////// Lighting:
                float3 finalColor = 0;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,0.0),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
