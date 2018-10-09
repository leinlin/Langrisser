using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000312 RID: 786
	[ProtoContract(Name = "JobConnection2SkinResource")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class JobConnection2SkinResource : IExtensible
	{
		// Token: 0x06002EDB RID: 11995 RVA: 0x000BAE08 File Offset: 0x000B9008
		public JobConnection2SkinResource()
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

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x000BAE70 File Offset: 0x000B9070
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x000BAE78 File Offset: 0x000B9078
		[ProtoMember(1, IsRequired = true, Name = "JobConnectionId", DataFormat = DataFormat.TwosComplement)]
		public int JobConnectionId
		{
			get
			{
				return this._JobConnectionId;
			}
			set
			{
				this._JobConnectionId = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x000BAE84 File Offset: 0x000B9084
		// (set) Token: 0x06002EDF RID: 11999 RVA: 0x000BAE8C File Offset: 0x000B908C
		[ProtoMember(2, IsRequired = true, Name = "SkinResourceId", DataFormat = DataFormat.TwosComplement)]
		public int SkinResourceId
		{
			get
			{
				return this._SkinResourceId;
			}
			set
			{
				this._SkinResourceId = value;
			}
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000BAE98 File Offset: 0x000B9098
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000BAEA8 File Offset: 0x000B90A8
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

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000BAF74 File Offset: 0x000B9174
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(JobConnection2SkinResource));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023EA RID: 9194
		private int _JobConnectionId;

		// Token: 0x040023EB RID: 9195
		private int _SkinResourceId;

		// Token: 0x040023EC RID: 9196
		private IExtension extensionObject;

		// Token: 0x040023ED RID: 9197
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023EE RID: 9198
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023EF RID: 9199
		private LuaFunction m_ctor_hotfix;
	}
}
