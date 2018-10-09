using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200084A RID: 2122
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ThearchyTrialLevelAttackReq")]
	[Serializable]
	public class ThearchyTrialLevelAttackReq : IExtensible
	{
		// Token: 0x06006A04 RID: 27140 RVA: 0x001DD4A8 File Offset: 0x001DB6A8
		public ThearchyTrialLevelAttackReq()
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

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06006A05 RID: 27141 RVA: 0x001DD510 File Offset: 0x001DB710
		// (set) Token: 0x06006A06 RID: 27142 RVA: 0x001DD518 File Offset: 0x001DB718
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x001DD524 File Offset: 0x001DB724
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x001DD534 File Offset: 0x001DB734
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

		// Token: 0x06006A09 RID: 27145 RVA: 0x001DD600 File Offset: 0x001DB800
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyTrialLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051B6 RID: 20918
		private int _LevelId;

		// Token: 0x040051B7 RID: 20919
		private IExtension extensionObject;

		// Token: 0x040051B8 RID: 20920
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051B9 RID: 20921
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051BA RID: 20922
		private LuaFunction m_ctor_hotfix;
	}
}
