﻿Shader "UTF_shader/HalfBrightness"
{
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader 
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			
			uniform sampler2D _MainTex;
			
			float4 frag(v2f_img i) : COLOR 
			{
				float4 c = tex2D(_MainTex, i.uv);

				return c * 0.1;
			}
			ENDCG
		}
	}
}