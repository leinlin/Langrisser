using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000736 RID: 1846
	[ProtoContract(Name = "DSResourceNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSResourceNtf : IExtensible
	{
		// Token: 0x06006137 RID: 24887 RVA: 0x001B6438 File Offset: 0x001B4638
		public DSResourceNtf()
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

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06006138 RID: 24888 RVA: 0x001B64A0 File Offset: 0x001B46A0
		// (set) Token: 0x06006139 RID: 24889 RVA: 0x001B64A8 File Offset: 0x001B46A8
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public int Version
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

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x001B64B4 File Offset: 0x001B46B4
		// (set) Token: 0x0600613B RID: 24891 RVA: 0x001B64BC File Offset: 0x001B46BC
		[ProtoMember(2, IsRequired = true, Name = "Resource", DataFormat = DataFormat.Default)]
		public ProResource Resource
		{
			get
			{
				return this._Resource;
			}
			set
			{
				this._Resource = value;
			}
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x001B64C8 File Offset: 0x001B46C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x001B64D8 File Offset: 0x001B46D8
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

		// Token: 0x0600613E RID: 24894 RVA: 0x001B65A4 File Offset: 0x001B47A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSResourceNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048CD RID: 18637
		private int _Version;

		// Token: 0x040048CE RID: 18638
		private ProResource _Resource;

		// Token: 0x040048CF RID: 18639
		private IExtension extensionObject;

		// Token: 0x040048D0 RID: 18640
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048D1 RID: 18641
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048D2 RID: 18642
		private LuaFunction m_ctor_hotfix;
	}
}
