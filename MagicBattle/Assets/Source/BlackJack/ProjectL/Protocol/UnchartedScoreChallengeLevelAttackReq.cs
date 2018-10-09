using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000856 RID: 2134
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UnchartedScoreChallengeLevelAttackReq")]
	[Serializable]
	public class UnchartedScoreChallengeLevelAttackReq : IExtensible
	{
		// Token: 0x06006A79 RID: 27257 RVA: 0x001DEB94 File Offset: 0x001DCD94
		public UnchartedScoreChallengeLevelAttackReq()
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

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06006A7A RID: 27258 RVA: 0x001DEBFC File Offset: 0x001DCDFC
		// (set) Token: 0x06006A7B RID: 27259 RVA: 0x001DEC04 File Offset: 0x001DCE04
		[ProtoMember(1, IsRequired = true, Name = "UnchartedScoreId", DataFormat = DataFormat.TwosComplement)]
		public int UnchartedScoreId
		{
			get
			{
				return this._UnchartedScoreId;
			}
			set
			{
				this._UnchartedScoreId = value;
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x001DEC10 File Offset: 0x001DCE10
		// (set) Token: 0x06006A7D RID: 27261 RVA: 0x001DEC18 File Offset: 0x001DCE18
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006A7E RID: 27262 RVA: 0x001DEC24 File Offset: 0x001DCE24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x001DEC34 File Offset: 0x001DCE34
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

		// Token: 0x06006A80 RID: 27264 RVA: 0x001DED00 File Offset: 0x001DCF00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreChallengeLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400520B RID: 21003
		private int _UnchartedScoreId;

		// Token: 0x0400520C RID: 21004
		private int _LevelId;

		// Token: 0x0400520D RID: 21005
		private IExtension extensionObject;

		// Token: 0x0400520E RID: 21006
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400520F RID: 21007
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005210 RID: 21008
		private LuaFunction m_ctor_hotfix;
	}
}
