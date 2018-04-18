// Shader created with Shader Forge v1.06 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.06;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:0,bdst:1,culm:0,dpts:2,wrdp:False,dith:0,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.1280277,fgcg:0.1953466,fgcb:0.2352941,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:9254,x:32537,y:32035,varname:node_9254,prsc:2|diff-2749-RGB,spec-954-OUT,alpha-2749-A;n:type:ShaderForge.SFN_Slider,id:3511,x:31993,y:33136,ptovrint:False,ptlb:roughness,ptin:_roughness,varname:node_3511,prsc:2,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Power,id:7212,x:32430,y:33170,varname:node_7212,prsc:2|VAL-3511-OUT,EXP-8795-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8795,x:32150,y:33285,ptovrint:False,ptlb:exp,ptin:_exp,varname:node_8795,prsc:2,glob:False,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:7112,x:32514,y:32901,ptovrint:False,ptlb:1,ptin:_1,varname:node_7112,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Pi,id:5194,x:32375,y:33004,varname:node_5194,prsc:2;n:type:ShaderForge.SFN_Divide,id:8613,x:32786,y:33006,varname:node_8613,prsc:2|A-7112-OUT,B-1896-OUT;n:type:ShaderForge.SFN_Multiply,id:1896,x:32604,y:33047,varname:node_1896,prsc:2|A-5194-OUT,B-7212-OUT;n:type:ShaderForge.SFN_NormalVector,id:2790,x:31579,y:32978,prsc:2,pt:False;n:type:ShaderForge.SFN_LightVector,id:5631,x:31579,y:33183,varname:node_5631,prsc:2;n:type:ShaderForge.SFN_ViewVector,id:5915,x:31579,y:33373,varname:node_5915,prsc:2;n:type:ShaderForge.SFN_HalfVector,id:9175,x:31579,y:32800,varname:node_9175,prsc:2;n:type:ShaderForge.SFN_Dot,id:7735,x:32419,y:32635,varname:node_7735,prsc:2,dt:0|A-2790-OUT,B-5915-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6410,x:32621,y:32532,ptovrint:False,ptlb:node_6410,ptin:_node_6410,varname:node_6410,prsc:2,glob:False,v1:2;n:type:ShaderForge.SFN_Divide,id:7122,x:32804,y:32612,varname:node_7122,prsc:2|A-6410-OUT,B-7212-OUT;n:type:ShaderForge.SFN_Subtract,id:7763,x:32996,y:32612,varname:node_7763,prsc:2|A-7122-OUT,B-6410-OUT;n:type:ShaderForge.SFN_Power,id:4153,x:33110,y:32814,varname:node_4153,prsc:2|VAL-7735-OUT,EXP-7763-OUT;n:type:ShaderForge.SFN_Multiply,id:887,x:33359,y:32904,varname:node_887,prsc:2|A-4153-OUT,B-8613-OUT;n:type:ShaderForge.SFN_Dot,id:2239,x:32036,y:33488,varname:node_2239,prsc:2,dt:0|A-2790-OUT,B-5631-OUT;n:type:ShaderForge.SFN_Dot,id:2568,x:32046,y:33721,varname:node_2568,prsc:2,dt:0|A-2790-OUT,B-5915-OUT;n:type:ShaderForge.SFN_Multiply,id:9445,x:32286,y:33607,varname:node_9445,prsc:2|A-2239-OUT,B-2568-OUT;n:type:ShaderForge.SFN_Slider,id:6401,x:31525,y:33988,ptovrint:False,ptlb:F,ptin:_F,varname:node_6401,prsc:2,min:0,cur:0.2824905,max:1;n:type:ShaderForge.SFN_OneMinus,id:4556,x:32029,y:34109,varname:node_4556,prsc:2|IN-6401-OUT;n:type:ShaderForge.SFN_Dot,id:7175,x:32042,y:34368,varname:node_7175,prsc:2,dt:0|A-5915-OUT,B-9175-OUT;n:type:ShaderForge.SFN_Power,id:5578,x:32465,y:34339,varname:node_5578,prsc:2|VAL-6511-OUT,EXP-2083-OUT;n:type:ShaderForge.SFN_OneMinus,id:6511,x:32212,y:34368,varname:node_6511,prsc:2|IN-7175-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2083,x:32299,y:34518,ptovrint:False,ptlb:node_2083,ptin:_node_2083,varname:node_2083,prsc:2,glob:False,v1:5;n:type:ShaderForge.SFN_Multiply,id:2519,x:32534,y:34143,varname:node_2519,prsc:2|A-4556-OUT,B-5578-OUT;n:type:ShaderForge.SFN_Add,id:3622,x:32713,y:34028,varname:node_3622,prsc:2|A-6401-OUT,B-2519-OUT;n:type:ShaderForge.SFN_Multiply,id:7446,x:33523,y:33511,varname:node_7446,prsc:2|A-887-OUT,B-9445-OUT,C-3622-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6116,x:33655,y:33740,ptovrint:False,ptlb:node_6116,ptin:_node_6116,varname:node_6116,prsc:2,glob:False,v1:4;n:type:ShaderForge.SFN_Dot,id:8144,x:33655,y:33814,varname:node_8144,prsc:2,dt:0|A-2790-OUT,B-5631-OUT;n:type:ShaderForge.SFN_Dot,id:61,x:33655,y:33975,varname:node_61,prsc:2,dt:0|A-2790-OUT,B-5915-OUT;n:type:ShaderForge.SFN_Multiply,id:1678,x:33961,y:33829,varname:node_1678,prsc:2|A-6116-OUT,B-8144-OUT,C-61-OUT;n:type:ShaderForge.SFN_Divide,id:954,x:34278,y:33739,varname:node_954,prsc:2|A-7446-OUT,B-1678-OUT;n:type:ShaderForge.SFN_Tex2d,id:2749,x:31592,y:32296,ptovrint:False,ptlb:node_2749,ptin:_node_2749,varname:node_2749,prsc:2,tex:b66bceaf0cc0ace4e9bdc92f14bba709,ntxv:0,isnm:False;proporder:3511-8795-7112-6410-6401-2083-6116-2749;pass:END;sub:END;*/

Shader "Shader Forge/SpecularBRDF" {
    Properties {
        _roughness ("roughness", Range(0, 1)) = 0
        _exp ("exp", Float ) = 2
        _1 ("1", Float ) = 1
        _node_6410 ("node_6410", Float ) = 2
        _F ("F", Range(0, 1)) = 0.2824905
        _node_2083 ("node_2083", Float ) = 5
        _node_6116 ("node_6116", Float ) = 4
        _node_2749 ("node_2749", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _roughness;
            uniform float _exp;
            uniform float _1;
            uniform float _node_6410;
            uniform float _F;
            uniform float _node_2083;
            uniform float _node_6116;
            uniform sampler2D _node_2749; uniform float4 _node_2749_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_7212 = pow(_roughness,_exp);
                float node_954 = (((pow(dot(i.normalDir,viewDirection),((_node_6410/node_7212)-_node_6410))*(_1/(3.141592654*node_7212)))*(dot(i.normalDir,lightDirection)*dot(i.normalDir,viewDirection))*(_F+((1.0 - _F)*pow((1.0 - dot(viewDirection,halfDirection)),_node_2083))))/(_node_6116*dot(i.normalDir,lightDirection)*dot(i.normalDir,viewDirection)));
                float3 specularColor = float3(node_954,node_954,node_954);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow);
                float3 specular = directSpecular * specularColor;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 indirectDiffuse = float3(0,0,0);
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _node_2749_var = tex2D(_node_2749,TRANSFORM_TEX(i.uv0, _node_2749));
                float3 diffuse = (directDiffuse + indirectDiffuse) * _node_2749_var.rgb;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor,_node_2749_var.a);
            }
            ENDCG
        }
        Pass {
            Name "ForwardAdd"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            Fog { Color (0,0,0,0) }
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _roughness;
            uniform float _exp;
            uniform float _1;
            uniform float _node_6410;
            uniform float _F;
            uniform float _node_2083;
            uniform float _node_6116;
            uniform sampler2D _node_2749; uniform float4 _node_2749_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_7212 = pow(_roughness,_exp);
                float node_954 = (((pow(dot(i.normalDir,viewDirection),((_node_6410/node_7212)-_node_6410))*(_1/(3.141592654*node_7212)))*(dot(i.normalDir,lightDirection)*dot(i.normalDir,viewDirection))*(_F+((1.0 - _F)*pow((1.0 - dot(viewDirection,halfDirection)),_node_2083))))/(_node_6116*dot(i.normalDir,lightDirection)*dot(i.normalDir,viewDirection)));
                float3 specularColor = float3(node_954,node_954,node_954);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow);
                float3 specular = directSpecular * specularColor;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _node_2749_var = tex2D(_node_2749,TRANSFORM_TEX(i.uv0, _node_2749));
                float3 diffuse = directDiffuse * _node_2749_var.rgb;
/// Final Color:
                float3 finalColor = diffuse + specular;
                return fixed4(finalColor * _node_2749_var.a,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
