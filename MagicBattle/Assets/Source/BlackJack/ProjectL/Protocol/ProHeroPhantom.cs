using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200068A RID: 1674
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProHeroPhantom")]
	[Serializable]
	public class ProHeroPhantom : IExtensible
	{
		// Token: 0x06005B27 RID: 23335 RVA: 0x001A1F3C File Offset: 0x001A013C
		public ProHeroPhantom()
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

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x001A1FB0 File Offset: 0x001A01B0
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x001A1FB8 File Offset: 0x001A01B8
		[ProtoMember(1, IsRequired = true, Name = "ConfigId", DataFormat = DataFormat.TwosComplement)]
		public int ConfigId
		{
			get
			{
				return this._ConfigId;
			}
			set
			{
				this._ConfigId = value;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x001A1FC4 File Offset: 0x001A01C4
		[ProtoMember(2, Name = "LevelsCleared", DataFormat = DataFormat.Default)]
		public List<ProHeroPhantomLevel> LevelsCleared
		{
			get
			{
				return this._LevelsCleared;
			}
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x001A1FCC File Offset: 0x001A01CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x001A1FDC File Offset: 0x001A01DC
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

		// Token: 0x06005B2D RID: 23341 RVA: 0x001A20A8 File Offset: 0x001A02A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroPhantom));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400443C RID: 17468
		private int _ConfigId;

		// Token: 0x0400443D RID: 17469
		private readonly List<ProHeroPhantomLevel> _LevelsCleared = new List<ProHeroPhantomLevel>();

		// Token: 0x0400443E RID: 17470
		private IExtension extensionObject;

		// Token: 0x0400443F RID: 17471
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004440 RID: 17472
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004441 RID: 17473
		private LuaFunction m_ctor_hotfix;
	}
}
