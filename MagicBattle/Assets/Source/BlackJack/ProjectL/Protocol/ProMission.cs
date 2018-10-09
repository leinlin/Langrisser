using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000655 RID: 1621
	[ProtoContract(Name = "ProMission")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProMission : IExtensible
	{
		// Token: 0x06005877 RID: 22647 RVA: 0x0019B270 File Offset: 0x00199470
		public ProMission()
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

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06005878 RID: 22648 RVA: 0x0019B2D8 File Offset: 0x001994D8
		// (set) Token: 0x06005879 RID: 22649 RVA: 0x0019B2E0 File Offset: 0x001994E0
		[ProtoMember(1, IsRequired = true, Name = "MissionId", DataFormat = DataFormat.TwosComplement)]
		public int MissionId
		{
			get
			{
				return this._MissionId;
			}
			set
			{
				this._MissionId = value;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x0019B2EC File Offset: 0x001994EC
		// (set) Token: 0x0600587B RID: 22651 RVA: 0x0019B2F4 File Offset: 0x001994F4
		[ProtoMember(2, IsRequired = true, Name = "MissionProcess", DataFormat = DataFormat.TwosComplement)]
		public long MissionProcess
		{
			get
			{
				return this._MissionProcess;
			}
			set
			{
				this._MissionProcess = value;
			}
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0019B300 File Offset: 0x00199500
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x0019B310 File Offset: 0x00199510
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

		// Token: 0x0600587E RID: 22654 RVA: 0x0019B3DC File Offset: 0x001995DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProMission));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004266 RID: 16998
		private int _MissionId;

		// Token: 0x04004267 RID: 16999
		private long _MissionProcess;

		// Token: 0x04004268 RID: 17000
		private IExtension extensionObject;

		// Token: 0x04004269 RID: 17001
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400426A RID: 17002
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400426B RID: 17003
		private LuaFunction m_ctor_hotfix;
	}
}
