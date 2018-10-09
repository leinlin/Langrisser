using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000B7 RID: 183
	public class LayerRenderSettingDesc : MonoBehaviour
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x0001EF64 File Offset: 0x0001D164
		public void CopyFrom(LayerRenderSettingDesc target)
		{
			this.enviornmentLighting = new LayerRenderSettingDesc.EnviornmentLighting();
			this.enviornmentLighting.SkyBox = target.enviornmentLighting.SkyBox;
			this.enviornmentLighting.AmbientSource = target.enviornmentLighting.AmbientSource;
			this.enviornmentLighting.AmbientIntensity = target.enviornmentLighting.AmbientIntensity;
			this.enviornmentLighting.SkyColor = target.enviornmentLighting.SkyColor;
			this.enviornmentLighting.EquatorColor = target.enviornmentLighting.EquatorColor;
			this.enviornmentLighting.GroundColor = target.enviornmentLighting.GroundColor;
			this.enviornmentLighting.AmbientColor = target.enviornmentLighting.AmbientColor;
			this.fog = new LayerRenderSettingDesc.Fog();
			this.fog.EnableFog = target.fog.EnableFog;
			this.fog.FogColor = target.fog.FogColor;
			this.fog.FogMode = target.fog.FogMode;
			this.fog.FogStart = target.fog.FogStart;
			this.fog.FogEnd = target.fog.FogEnd;
			this.fog.FogDensity = target.fog.FogDensity;
		}

		// Token: 0x0400046B RID: 1131
		public LayerRenderSettingDesc.EnviornmentLighting enviornmentLighting;

		// Token: 0x0400046C RID: 1132
		public LayerRenderSettingDesc.Fog fog;

		// Token: 0x020000B8 RID: 184
		[Serializable]
		public class EnviornmentLighting
		{
			// Token: 0x0400046D RID: 1133
			public Material SkyBox;

			// Token: 0x0400046E RID: 1134
			public AmbientMode AmbientSource;

			// Token: 0x0400046F RID: 1135
			public float AmbientIntensity;

			// Token: 0x04000470 RID: 1136
			[Header("TrilightMode Colors")]
			public Color SkyColor;

			// Token: 0x04000471 RID: 1137
			public Color EquatorColor;

			// Token: 0x04000472 RID: 1138
			public Color GroundColor;

			// Token: 0x04000473 RID: 1139
			[Header("FlatMode Color")]
			public Color AmbientColor;
		}

		// Token: 0x020000B9 RID: 185
		[Serializable]
		public class Fog
		{
			// Token: 0x04000474 RID: 1140
			public bool EnableFog;

			// Token: 0x04000475 RID: 1141
			public Color FogColor;

			// Token: 0x04000476 RID: 1142
			public FogMode FogMode;

			// Token: 0x04000477 RID: 1143
			[Header("LinearMode")]
			public float FogStart;

			// Token: 0x04000478 RID: 1144
			public float FogEnd;

			// Token: 0x04000479 RID: 1145
			[Header("ExponentialMode")]
			public float FogDensity;
		}
	}
}
