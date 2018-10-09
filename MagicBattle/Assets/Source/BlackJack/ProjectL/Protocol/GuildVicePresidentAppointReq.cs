using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000775 RID: 1909
	[ProtoContract(Name = "GuildVicePresidentAppointReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildVicePresidentAppointReq : IExtensible
	{
		// Token: 0x06006315 RID: 25365 RVA: 0x001BD6E0 File Offset: 0x001BB8E0
		public GuildVicePresidentAppointReq()
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

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06006316 RID: 25366 RVA: 0x001BD748 File Offset: 0x001BB948
		// (set) Token: 0x06006317 RID: 25367 RVA: 0x001BD750 File Offset: 0x001BB950
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x001BD75C File Offset: 0x001BB95C
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x001BD764 File Offset: 0x001BB964
		[ProtoMember(2, IsRequired = true, Name = "Appoint", DataFormat = DataFormat.Default)]
		public bool Appoint
		{
			get
			{
				return this._Appoint;
			}
			set
			{
				this._Appoint = value;
			}
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x001BD770 File Offset: 0x001BB970
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x001BD780 File Offset: 0x001BB980
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

		// Token: 0x0600631C RID: 25372 RVA: 0x001BD84C File Offset: 0x001BBA4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildVicePresidentAppointReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A3F RID: 19007
		private string _UserId;

		// Token: 0x04004A40 RID: 19008
		private bool _Appoint;

		// Token: 0x04004A41 RID: 19009
		private IExtension extensionObject;

		// Token: 0x04004A42 RID: 19010
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A43 RID: 19011
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A44 RID: 19012
		private LuaFunction m_ctor_hotfix;
	}
}
