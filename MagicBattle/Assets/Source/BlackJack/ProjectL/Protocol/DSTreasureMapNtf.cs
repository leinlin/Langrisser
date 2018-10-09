using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200072A RID: 1834
	[ProtoContract(Name = "DSTreasureMapNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSTreasureMapNtf : IExtensible
	{
		// Token: 0x060060C5 RID: 24773 RVA: 0x001B4D10 File Offset: 0x001B2F10
		public DSTreasureMapNtf()
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

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x060060C6 RID: 24774 RVA: 0x001B4D84 File Offset: 0x001B2F84
		// (set) Token: 0x060060C7 RID: 24775 RVA: 0x001B4D8C File Offset: 0x001B2F8C
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

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x060060C8 RID: 24776 RVA: 0x001B4D98 File Offset: 0x001B2F98
		[ProtoMember(2, Name = "FinishedLeves", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedLeves
		{
			get
			{
				return this._FinishedLeves;
			}
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x001B4DA0 File Offset: 0x001B2FA0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x001B4DB0 File Offset: 0x001B2FB0
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

		// Token: 0x060060CB RID: 24779 RVA: 0x001B4E7C File Offset: 0x001B307C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSTreasureMapNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004875 RID: 18549
		private uint _Version;

		// Token: 0x04004876 RID: 18550
		private readonly List<int> _FinishedLeves = new List<int>();

		// Token: 0x04004877 RID: 18551
		private IExtension extensionObject;

		// Token: 0x04004878 RID: 18552
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004879 RID: 18553
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400487A RID: 18554
		private LuaFunction m_ctor_hotfix;
	}
}
