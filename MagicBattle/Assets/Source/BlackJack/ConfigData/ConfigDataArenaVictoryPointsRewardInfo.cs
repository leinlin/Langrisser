using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000202 RID: 514
	[ProtoContract(Name = "ConfigDataArenaVictoryPointsRewardInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataArenaVictoryPointsRewardInfo : IExtensible
	{
		// Token: 0x06001D8B RID: 7563 RVA: 0x0009B388 File Offset: 0x00099588
		public ConfigDataArenaVictoryPointsRewardInfo()
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

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0009B3FC File Offset: 0x000995FC
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0009B404 File Offset: 0x00099604
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0009B410 File Offset: 0x00099610
		[ProtoMember(3, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x0009B418 File Offset: 0x00099618
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0009B420 File Offset: 0x00099620
		[ProtoMember(4, IsRequired = true, Name = "VictoryPoints", DataFormat = DataFormat.TwosComplement)]
		public int VictoryPoints
		{
			get
			{
				return this._VictoryPoints;
			}
			set
			{
				this._VictoryPoints = value;
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0009B42C File Offset: 0x0009962C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0009B43C File Offset: 0x0009963C
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

		// Token: 0x06001D93 RID: 7571 RVA: 0x0009B508 File Offset: 0x00099708
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaVictoryPointsRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011AA RID: 4522
		private int _ID;

		// Token: 0x040011AB RID: 4523
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x040011AC RID: 4524
		private int _VictoryPoints;

		// Token: 0x040011AD RID: 4525
		private IExtension extensionObject;

		// Token: 0x040011AE RID: 4526
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011AF RID: 4527
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011B0 RID: 4528
		private LuaFunction m_ctor_hotfix;
	}
}
