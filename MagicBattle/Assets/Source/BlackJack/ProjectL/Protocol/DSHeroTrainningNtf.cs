using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200072F RID: 1839
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSHeroTrainningNtf")]
	[Serializable]
	public class DSHeroTrainningNtf : IExtensible
	{
		// Token: 0x060060ED RID: 24813 RVA: 0x001B566C File Offset: 0x001B386C
		public DSHeroTrainningNtf()
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

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x001B56E0 File Offset: 0x001B38E0
		// (set) Token: 0x060060EF RID: 24815 RVA: 0x001B56E8 File Offset: 0x001B38E8
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

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060060F0 RID: 24816 RVA: 0x001B56F4 File Offset: 0x001B38F4
		[ProtoMember(2, Name = "FinishedLeves", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedLeves
		{
			get
			{
				return this._FinishedLeves;
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060060F1 RID: 24817 RVA: 0x001B56FC File Offset: 0x001B38FC
		// (set) Token: 0x060060F2 RID: 24818 RVA: 0x001B5704 File Offset: 0x001B3904
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

		// Token: 0x060060F3 RID: 24819 RVA: 0x001B5710 File Offset: 0x001B3910
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x001B5720 File Offset: 0x001B3920
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

		// Token: 0x060060F5 RID: 24821 RVA: 0x001B57EC File Offset: 0x001B39EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSHeroTrainningNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004896 RID: 18582
		private uint _Version;

		// Token: 0x04004897 RID: 18583
		private readonly List<int> _FinishedLeves = new List<int>();

		// Token: 0x04004898 RID: 18584
		private int _ChallengedNums;

		// Token: 0x04004899 RID: 18585
		private IExtension extensionObject;

		// Token: 0x0400489A RID: 18586
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400489B RID: 18587
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400489C RID: 18588
		private LuaFunction m_ctor_hotfix;
	}
}
