using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000723 RID: 1827
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSAnikiGymNtf")]
	[Serializable]
	public class DSAnikiGymNtf : IExtensible
	{
		// Token: 0x0600608A RID: 24714 RVA: 0x001B3FC0 File Offset: 0x001B21C0
		public DSAnikiGymNtf()
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

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x001B4034 File Offset: 0x001B2234
		// (set) Token: 0x0600608C RID: 24716 RVA: 0x001B403C File Offset: 0x001B223C
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x001B4048 File Offset: 0x001B2248
		[ProtoMember(2, Name = "FinishedLeves", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedLeves
		{
			get
			{
				return this._FinishedLeves;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x001B4050 File Offset: 0x001B2250
		// (set) Token: 0x0600608F RID: 24719 RVA: 0x001B4058 File Offset: 0x001B2258
		[ProtoMember(3, IsRequired = true, Name = "ChallengedNums", DataFormat = DataFormat.TwosComplement)]
		public int ChallengedNums
		{
			get
			{
				return this._ChallengedNums;
			}
			set
			{
				this._ChallengedNums = value;
			}
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x001B4064 File Offset: 0x001B2264
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x001B4074 File Offset: 0x001B2274
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

		// Token: 0x06006092 RID: 24722 RVA: 0x001B4140 File Offset: 0x001B2340
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSAnikiGymNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004844 RID: 18500
		private uint _Version;

		// Token: 0x04004845 RID: 18501
		private readonly List<int> _FinishedLeves = new List<int>();

		// Token: 0x04004846 RID: 18502
		private int _ChallengedNums;

		// Token: 0x04004847 RID: 18503
		private IExtension extensionObject;

		// Token: 0x04004848 RID: 18504
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004849 RID: 18505
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400484A RID: 18506
		private LuaFunction m_ctor_hotfix;
	}
}
