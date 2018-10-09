using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007E0 RID: 2016
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelScenarioHandleReq")]
	[Serializable]
	public class LevelScenarioHandleReq : IExtensible
	{
		// Token: 0x060066BE RID: 26302 RVA: 0x001C9E64 File Offset: 0x001C8064
		public LevelScenarioHandleReq()
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

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x060066BF RID: 26303 RVA: 0x001C9ECC File Offset: 0x001C80CC
		// (set) Token: 0x060066C0 RID: 26304 RVA: 0x001C9ED4 File Offset: 0x001C80D4
		[ProtoMember(1, IsRequired = true, Name = "ScenarioId", DataFormat = DataFormat.TwosComplement)]
		public int ScenarioId
		{
			get
			{
				return this._ScenarioId;
			}
			set
			{
				this._ScenarioId = value;
			}
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x001C9EE0 File Offset: 0x001C80E0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x001C9EF0 File Offset: 0x001C80F0
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

		// Token: 0x060066C3 RID: 26307 RVA: 0x001C9FBC File Offset: 0x001C81BC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelScenarioHandleReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CF4 RID: 19700
		private int _ScenarioId;

		// Token: 0x04004CF5 RID: 19701
		private IExtension extensionObject;

		// Token: 0x04004CF6 RID: 19702
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CF7 RID: 19703
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CF8 RID: 19704
		private LuaFunction m_ctor_hotfix;
	}
}
