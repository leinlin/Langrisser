using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200024B RID: 587
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroInteractionInfo")]
	[Serializable]
	public class ConfigDataHeroInteractionInfo : IExtensible
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x000A7590 File Offset: 0x000A5790
		public ConfigDataHeroInteractionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000A7604 File Offset: 0x000A5804
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x000A760C File Offset: 0x000A580C
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000A7618 File Offset: 0x000A5818
		[ProtoMember(3, Name = "Results", DataFormat = DataFormat.Default)]
		public List<HeroInteractionWeightResult> Results
		{
			get
			{
				return this._Results;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x000A7620 File Offset: 0x000A5820
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x000A7628 File Offset: 0x000A5828
		[ProtoMember(4, IsRequired = true, Name = "NormalResultPerformance", DataFormat = DataFormat.TwosComplement)]
		public int NormalResultPerformance
		{
			get
			{
				return this._NormalResultPerformance;
			}
			set
			{
				this._NormalResultPerformance = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x000A7634 File Offset: 0x000A5834
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x000A763C File Offset: 0x000A583C
		[ProtoMember(5, IsRequired = true, Name = "SmallUpResultPerformance", DataFormat = DataFormat.TwosComplement)]
		public int SmallUpResultPerformance
		{
			get
			{
				return this._SmallUpResultPerformance;
			}
			set
			{
				this._SmallUpResultPerformance = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000A7648 File Offset: 0x000A5848
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x000A7650 File Offset: 0x000A5850
		[ProtoMember(6, IsRequired = true, Name = "BigUpResultPerformance", DataFormat = DataFormat.TwosComplement)]
		public int BigUpResultPerformance
		{
			get
			{
				return this._BigUpResultPerformance;
			}
			set
			{
				this._BigUpResultPerformance = value;
			}
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x000A765C File Offset: 0x000A585C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000A766C File Offset: 0x000A586C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x000A7738 File Offset: 0x000A5938
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroInteractionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001653 RID: 5715
		private int _ID;

		// Token: 0x04001654 RID: 5716
		private readonly List<HeroInteractionWeightResult> _Results = new List<HeroInteractionWeightResult>();

		// Token: 0x04001655 RID: 5717
		private int _NormalResultPerformance;

		// Token: 0x04001656 RID: 5718
		private int _SmallUpResultPerformance;

		// Token: 0x04001657 RID: 5719
		private int _BigUpResultPerformance;

		// Token: 0x04001658 RID: 5720
		private IExtension extensionObject;

		// Token: 0x04001659 RID: 5721
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400165A RID: 5722
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400165B RID: 5723
		private LuaFunction m_ctor_hotfix;
	}
}
