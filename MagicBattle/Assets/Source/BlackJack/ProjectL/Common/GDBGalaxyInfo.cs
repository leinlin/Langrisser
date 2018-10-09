using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000323 RID: 803
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBGalaxyInfo")]
	[Serializable]
	public class GDBGalaxyInfo : IExtensible
	{
		// Token: 0x06002F7F RID: 12159 RVA: 0x000BCE34 File Offset: 0x000BB034
		public GDBGalaxyInfo()
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

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000BCEB0 File Offset: 0x000BB0B0
		[ProtoMember(1, Name = "starfields", DataFormat = DataFormat.Default)]
		public List<GDBStarfieldsSimpleInfo> Starfields
		{
			get
			{
				return this._starfields;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x000BCEB8 File Offset: 0x000BB0B8
		[ProtoMember(2, Name = "LinkList", DataFormat = DataFormat.Default)]
		public List<GDBLinkInfo> LinkList
		{
			get
			{
				return this._LinkList;
			}
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x000BCEC0 File Offset: 0x000BB0C0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000BCED0 File Offset: 0x000BB0D0
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

		// Token: 0x06002F84 RID: 12164 RVA: 0x000BCF9C File Offset: 0x000BB19C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBGalaxyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400245E RID: 9310
		private readonly List<GDBStarfieldsSimpleInfo> _starfields = new List<GDBStarfieldsSimpleInfo>();

		// Token: 0x0400245F RID: 9311
		private readonly List<GDBLinkInfo> _LinkList = new List<GDBLinkInfo>();

		// Token: 0x04002460 RID: 9312
		private IExtension extensionObject;

		// Token: 0x04002461 RID: 9313
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002462 RID: 9314
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002463 RID: 9315
		private LuaFunction m_ctor_hotfix;
	}
}
