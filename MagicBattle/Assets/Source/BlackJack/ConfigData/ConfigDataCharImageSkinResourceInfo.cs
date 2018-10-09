using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200021F RID: 543
	[ProtoContract(Name = "ConfigDataCharImageSkinResourceInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataCharImageSkinResourceInfo : IExtensible
	{
		// Token: 0x06002043 RID: 8259 RVA: 0x000A0268 File Offset: 0x0009E468
		public ConfigDataCharImageSkinResourceInfo()
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

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x000A02D0 File Offset: 0x0009E4D0
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x000A02D8 File Offset: 0x0009E4D8
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

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x000A02E4 File Offset: 0x0009E4E4
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x000A02EC File Offset: 0x0009E4EC
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x000A02F8 File Offset: 0x0009E4F8
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x000A0300 File Offset: 0x0009E500
		[ProtoMember(4, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x000A030C File Offset: 0x0009E50C
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x000A0314 File Offset: 0x0009E514
		[ProtoMember(5, IsRequired = true, Name = "SpineAssetPath", DataFormat = DataFormat.Default)]
		public string SpineAssetPath
		{
			get
			{
				return this._SpineAssetPath;
			}
			set
			{
				this._SpineAssetPath = value;
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000A0320 File Offset: 0x0009E520
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000A0330 File Offset: 0x0009E530
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

		// Token: 0x0600204E RID: 8270 RVA: 0x000A03FC File Offset: 0x0009E5FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCharImageSkinResourceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001379 RID: 4985
		private int _ID;

		// Token: 0x0400137A RID: 4986
		private string _Name;

		// Token: 0x0400137B RID: 4987
		private string _Image;

		// Token: 0x0400137C RID: 4988
		private string _SpineAssetPath;

		// Token: 0x0400137D RID: 4989
		private IExtension extensionObject;

		// Token: 0x0400137E RID: 4990
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400137F RID: 4991
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001380 RID: 4992
		private LuaFunction m_ctor_hotfix;
	}
}
