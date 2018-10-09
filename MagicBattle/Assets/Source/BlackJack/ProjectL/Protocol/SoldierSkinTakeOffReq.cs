using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D1 RID: 2001
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SoldierSkinTakeOffReq")]
	[Serializable]
	public class SoldierSkinTakeOffReq : IExtensible
	{
		// Token: 0x06006634 RID: 26164 RVA: 0x001C8210 File Offset: 0x001C6410
		public SoldierSkinTakeOffReq()
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

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06006635 RID: 26165 RVA: 0x001C8278 File Offset: 0x001C6478
		// (set) Token: 0x06006636 RID: 26166 RVA: 0x001C8280 File Offset: 0x001C6480
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06006637 RID: 26167 RVA: 0x001C828C File Offset: 0x001C648C
		// (set) Token: 0x06006638 RID: 26168 RVA: 0x001C8294 File Offset: 0x001C6494
		[ProtoMember(2, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierId
		{
			get
			{
				return this._SoldierId;
			}
			set
			{
				this._SoldierId = value;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06006639 RID: 26169 RVA: 0x001C82A0 File Offset: 0x001C64A0
		// (set) Token: 0x0600663A RID: 26170 RVA: 0x001C82A8 File Offset: 0x001C64A8
		[ProtoMember(3, IsRequired = true, Name = "All", DataFormat = DataFormat.Default)]
		public bool All
		{
			get
			{
				return this._All;
			}
			set
			{
				this._All = value;
			}
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x001C82B4 File Offset: 0x001C64B4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x001C82C4 File Offset: 0x001C64C4
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

		// Token: 0x0600663D RID: 26173 RVA: 0x001C8390 File Offset: 0x001C6590
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierSkinTakeOffReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C8E RID: 19598
		private int _HeroId;

		// Token: 0x04004C8F RID: 19599
		private int _SoldierId;

		// Token: 0x04004C90 RID: 19600
		private bool _All;

		// Token: 0x04004C91 RID: 19601
		private IExtension extensionObject;

		// Token: 0x04004C92 RID: 19602
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C93 RID: 19603
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C94 RID: 19604
		private LuaFunction m_ctor_hotfix;
	}
}
