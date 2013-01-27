Shader "Custom/TransparentSingleColorShader" {
  Properties {
    _Color ("Color", Color) = (1.0, 1.0, 1.0, 1.0)
   // _MainTex ("Texture", 2D) = "white" {}
  }
  SubShader {
    Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }
    Blend SrcAlpha OneMinusSrcAlpha
    Cull Off
    LOD 200
 
    CGPROGRAM
    #pragma surface surf Lambert
 
    fixed4 _Color;
    //uniform float4 _Color;
    //sampler2D _MainTex;
 
    // Note: pointless texture coordinate. I couldn't get Unity (or Cg)
    //       to accept an empty Input structure or omit the inputs.
    struct Input {
      float2 uv_MainTex;
    };
 
    void surf (Input IN, inout SurfaceOutput o) {
    //float4 frag(v2f i) : COLOR {
      o.Albedo = _Color.rgb;// * tex2D(_MainTex, _mainTex.texcoord).rgb;
      //o.Albedo = tex2D(_MainTex, i.texcoord)*_Color;
      o.Emission = _Color.rgb * _Color.a;
      o.Alpha = _Color.a;
    }
    
   
    
    ENDCG
  } 
  FallBack "Diffuse"
}
