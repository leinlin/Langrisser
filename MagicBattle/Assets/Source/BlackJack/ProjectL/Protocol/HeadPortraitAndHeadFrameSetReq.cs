using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000706 RID: 1798
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeadPortraitAndHeadFrameSetReq")]
	[Serializable]
	public class HeadPortraitAndHeadFrameSetReq : IExtensible
	{
		// Token: 0x06005F71 RID: 24433 RVA: 0x001B0838 File Offset: 0x001AEA38
		public HeadPortraitAndHeadFrameSetReq()
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

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06005F72 RID: 24434 RVA: 0x001B08A0 File Offset: 0x001AEAA0
		// (set) Token: 0x06005F73 RID: 24435 RVA: 0x001B08A8 File Offset: 0x001AEAA8
		[ProtoMember(1, IsRequired = true, Name = "HeadPortraitId", DataFormat = DataFormat.TwosComplement)]
		public int HeadPortraitId
		{
			get
			{
				return this._HeadPortraitId;
			}
			set
			{
				this._HeadPortraitId = value;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x001B08B4 File Offset: 0x001AEAB4
		// (set) Token: 0x06005F75 RID: 24437 RVA: 0x001B08BC File Offset: 0x001AEABC
		[ProtoMember(2, IsRequired = true, Name = "HeadFrameId", DataFormat = DataFormat.TwosComplement)]
		public int HeadFrameId
		{
			get
			{
				return this._HeadFrameId;
			}
			set
			{
				this._HeadFrameId = value;
			}
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x001B08C8 File Offset: 0x001AEAC8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x001B08D8 File Offset: 0x001AEAD8
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

		// Token: 0x06005F78 RID: 24440 RVA: 0x001B09A4 File Offset: 0x001AEBA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeadPortraitAndHeadFrameSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004775 RID: 18293
		private int _HeadPortraitId;

		// Token: 0x04004776 RID: 18294
		private int _HeadFrameId;

		// Token: 0x04004777 RID: 18295
		private IExtension extensionObject;

		// Token: 0x04004778 RID: 18296
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004779 RID: 18297
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400477A RID: 18298
		private LuaFunction m_ctor_hotfix;
	}
}
