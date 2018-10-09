using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000722 RID: 1826
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSThearchyTrialNtf")]
	[Serializable]
	public class DSThearchyTrialNtf : IExtensible
	{
		// Token: 0x06006081 RID: 24705 RVA: 0x001B3DD8 File Offset: 0x001B1FD8
		public DSThearchyTrialNtf()
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

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06006082 RID: 24706 RVA: 0x001B3E4C File Offset: 0x001B204C
		// (set) Token: 0x06006083 RID: 24707 RVA: 0x001B3E54 File Offset: 0x001B2054
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

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06006084 RID: 24708 RVA: 0x001B3E60 File Offset: 0x001B2060
		[ProtoMember(2, Name = "FinishedLeves", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedLeves
		{
			get
			{
				return this._FinishedLeves;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x001B3E68 File Offset: 0x001B2068
		// (set) Token: 0x06006086 RID: 24710 RVA: 0x001B3E70 File Offset: 0x001B2070
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

		// Token: 0x06006087 RID: 24711 RVA: 0x001B3E7C File Offset: 0x001B207C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x001B3E8C File Offset: 0x001B208C
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

		// Token: 0x06006089 RID: 24713 RVA: 0x001B3F58 File Offset: 0x001B2158
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSThearchyTrialNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400483D RID: 18493
		private uint _Version;

		// Token: 0x0400483E RID: 18494
		private readonly List<int> _FinishedLeves = new List<int>();

		// Token: 0x0400483F RID: 18495
		private int _ChallengedNums;

		// Token: 0x04004840 RID: 18496
		private IExtension extensionObject;

		// Token: 0x04004841 RID: 18497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004842 RID: 18498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004843 RID: 18499
		private LuaFunction m_ctor_hotfix;
	}
}
