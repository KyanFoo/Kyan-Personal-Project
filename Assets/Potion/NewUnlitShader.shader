Shader "Shader Graphs/FillShader"
{
	Properties
    {
        _FillLevel ("Fill Level", Range(0, 1)) = 1
        _Speed ("Speed", Float) = 1
        _Amplitude ("Amplitude", Float) = 0.1
        _Frequency ("Frequency", Float) = 2
        _LiquidColor ("Liquid Color", Color) = (1,1,1,1)
    }
    SubShader
    {
        Tags{ "RenderType" = "Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float _FillLevel;
            float _Speed;
            float _Amplitude;
            float _Frequency;
            float4 _LiquidColor;

            v2f vert(appdata_t v)
            {
                v2f o;
                // Apply distortion based on fill level
                float3 pos = v.vertex.xyz;
                pos.y += sin(pos.x * _Frequency + _Time.y * _Speed) * _Amplitude * _FillLevel;
                o.vertex = UnityObjectToClipPos(pos);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                // Use the specified liquid color
                return _LiquidColor;
            }
            ENDCG
        }
    }
}