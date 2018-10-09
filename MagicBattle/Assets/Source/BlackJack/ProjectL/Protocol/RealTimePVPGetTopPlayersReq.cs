using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000813 RID: 2067
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPGetTopPlayersReq")]
	[Serializable]
	public class RealTimePVPGetTopPlayersReq : IExtensible
	{
		// Token: 0x06006857 RID: 26711 RVA: 0x001D7000 File Offset: 0x001D5200
		public RealTimePVPGetTopPlayersReq()
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

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x001D7068 File Offset: 0x001D5268
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x001D7070 File Offset: 0x001D5270
		[ProtoMember(1, IsRequired = true, Name = "TopN", DataFormat = DataFormat.TwosComplement)]
		public int TopN
		{
			get
			{
				return this._TopN;
			}
			set
			{
				this._TopN = value;
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x001D707C File Offset: 0x001D527C
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x001D7084 File Offset: 0x001D5284
		[ProtoMember(2, IsRequired = true, Name = "IsGlobal", DataFormat = DataFormat.Default)]
		public bool IsGlobal
		{
			get
			{
				return this._IsGlobal;
			}
			set
			{
				this._IsGlobal = value;
			}
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x001D7090 File Offset: 0x001D5290
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x001D70A0 File Offset: 0x001D52A0
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

		// Token: 0x0600685E RID: 26718 RVA: 0x001D716C File Offset: 0x001D536C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPGetTopPlayersReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400506A RID: 20586
		private int _TopN;

		// Token: 0x0400506B RID: 20587
		private bool _IsGlobal;

		// Token: 0x0400506C RID: 20588
		private IExtension extensionObject;

		// Token: 0x0400506D RID: 20589
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400506E RID: 20590
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400506F RID: 20591
		private LuaFunction m_ctor_hotfix;
	}
}
