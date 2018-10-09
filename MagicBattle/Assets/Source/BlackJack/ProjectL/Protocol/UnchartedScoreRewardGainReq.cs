using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000854 RID: 2132
	[ProtoContract(Name = "UnchartedScoreRewardGainReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UnchartedScoreRewardGainReq : IExtensible
	{
		// Token: 0x06006A65 RID: 27237 RVA: 0x001DE7C4 File Offset: 0x001DC9C4
		public UnchartedScoreRewardGainReq()
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

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06006A66 RID: 27238 RVA: 0x001DE82C File Offset: 0x001DCA2C
		// (set) Token: 0x06006A67 RID: 27239 RVA: 0x001DE834 File Offset: 0x001DCA34
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

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06006A68 RID: 27240 RVA: 0x001DE840 File Offset: 0x001DCA40
		// (set) Token: 0x06006A69 RID: 27241 RVA: 0x001DE848 File Offset: 0x001DCA48
		[ProtoMember(2, IsRequired = true, Name = "score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get
			{
				return this._score;
			}
			set
			{
				this._score = value;
			}
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x001DE854 File Offset: 0x001DCA54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x001DE864 File Offset: 0x001DCA64
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

		// Token: 0x06006A6C RID: 27244 RVA: 0x001DE930 File Offset: 0x001DCB30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreRewardGainReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051FD RID: 20989
		private int _UnchartedScoreId;

		// Token: 0x040051FE RID: 20990
		private int _score;

		// Token: 0x040051FF RID: 20991
		private IExtension extensionObject;

		// Token: 0x04005200 RID: 20992
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005201 RID: 20993
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005202 RID: 20994
		private LuaFunction m_ctor_hotfix;
	}
}
