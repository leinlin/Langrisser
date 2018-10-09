using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000732 RID: 1842
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSCooperateBattleNtf")]
	[Serializable]
	public class DSCooperateBattleNtf : IExtensible
	{
		// Token: 0x0600611A RID: 24858 RVA: 0x001B5CE8 File Offset: 0x001B3EE8
		public DSCooperateBattleNtf()
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

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x0600611B RID: 24859 RVA: 0x001B5D5C File Offset: 0x001B3F5C
		// (set) Token: 0x0600611C RID: 24860 RVA: 0x001B5D64 File Offset: 0x001B3F64
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

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x001B5D70 File Offset: 0x001B3F70
		[ProtoMember(2, Name = "CooperateBattles", DataFormat = DataFormat.Default)]
		public List<ProCooperateBattle> CooperateBattles
		{
			get
			{
				return this._CooperateBattles;
			}
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x001B5D78 File Offset: 0x001B3F78
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x001B5D88 File Offset: 0x001B3F88
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

		// Token: 0x06006120 RID: 24864 RVA: 0x001B5E54 File Offset: 0x001B4054
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSCooperateBattleNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048B5 RID: 18613
		private uint _Version;

		// Token: 0x040048B6 RID: 18614
		private readonly List<ProCooperateBattle> _CooperateBattles = new List<ProCooperateBattle>();

		// Token: 0x040048B7 RID: 18615
		private IExtension extensionObject;

		// Token: 0x040048B8 RID: 18616
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048B9 RID: 18617
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048BA RID: 18618
		private LuaFunction m_ctor_hotfix;
	}
}
