using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006CB RID: 1739
	[ProtoContract(Name = "FriendFindReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendFindReq : IExtensible
	{
		// Token: 0x06005DA6 RID: 23974 RVA: 0x001A9C3C File Offset: 0x001A7E3C
		public FriendFindReq()
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

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x001A9CA4 File Offset: 0x001A7EA4
		// (set) Token: 0x06005DA8 RID: 23976 RVA: 0x001A9CAC File Offset: 0x001A7EAC
		[ProtoMember(1, IsRequired = true, Name = "TargetBornChannelId", DataFormat = DataFormat.TwosComplement)]
		public int TargetBornChannelId
		{
			get
			{
				return this._TargetBornChannelId;
			}
			set
			{
				this._TargetBornChannelId = value;
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x001A9CB8 File Offset: 0x001A7EB8
		// (set) Token: 0x06005DAA RID: 23978 RVA: 0x001A9CC0 File Offset: 0x001A7EC0
		[ProtoMember(2, IsRequired = true, Name = "PartialName", DataFormat = DataFormat.Default)]
		public string PartialName
		{
			get
			{
				return this._PartialName;
			}
			set
			{
				this._PartialName = value;
			}
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x001A9CCC File Offset: 0x001A7ECC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x001A9CDC File Offset: 0x001A7EDC
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

		// Token: 0x06005DAD RID: 23981 RVA: 0x001A9DA8 File Offset: 0x001A7FA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendFindReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004613 RID: 17939
		private int _TargetBornChannelId;

		// Token: 0x04004614 RID: 17940
		private string _PartialName;

		// Token: 0x04004615 RID: 17941
		private IExtension extensionObject;

		// Token: 0x04004616 RID: 17942
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004617 RID: 17943
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004618 RID: 17944
		private LuaFunction m_ctor_hotfix;
	}
}
