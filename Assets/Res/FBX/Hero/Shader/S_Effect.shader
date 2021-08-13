Shader "CG3D/Effect" {
Properties {
 _MainTex ("Base (RGB), Alpha (A)", 2D) = "black" {}
 _TintColor ("_TintColor", Color) = (1,1,1,1)
}
SubShader { 
 LOD 100
 Tags { "QUEUE"="Transparent+1000" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "QUEUE"="Transparent+1000" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Cull Off
  Fog { Mode Off }
  Blend One One
  AlphaTest Greater 0.15
  ColorMask RGB
  ColorMaterial AmbientAndDiffuse
  SetTexture [_MainTex] { combine texture * primary }
  SetTexture [_MainTex] { ConstantColor [_TintColor] combine previous * constant }
 }
}
}