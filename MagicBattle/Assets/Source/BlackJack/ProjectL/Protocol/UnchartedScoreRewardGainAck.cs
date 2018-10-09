using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000855 RID: 2133
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UnchartedScoreRewardGainAck")]
	[Serializable]
	public class UnchartedScoreRewardGainAck : IExtensible
	{
		// Token: 0x06006A6D RID: 27245 RVA: 0x001DE998 File Offset: 0x001DCB98
		public UnchartedScoreRewardGainAck()
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

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06006A6E RID: 27246 RVA: 0x001DEA00 File Offset: 0x001DCC00
		// (set) Token: 0x06006A6F RID: 27247 RVA: 0x001DEA08 File Offset: 0x001DCC08
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06006A70 RID: 27248 RVA: 0x001DEA14 File Offset: 0x001DCC14
		// (set) Token: 0x06006A71 RID: 27249 RVA: 0x001DEA1C File Offset: 0x001DCC1C
		[ProtoMember(2, IsRequired = true, Name = "UnchartedScoreId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06006A72 RID: 27250 RVA: 0x001DEA28 File Offset: 0x001DCC28
		// (set) Token: 0x06006A73 RID: 27251 RVA: 0x001DEA30 File Offset: 0x001DCC30
		[ProtoMember(3, IsRequired = true, Name = "score", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06006A74 RID: 27252 RVA: 0x001DEA3C File Offset: 0x001DCC3C
		// (set) Token: 0x06006A75 RID: 27253 RVA: 0x001DEA44 File Offset: 0x001DCC44
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x001DEA50 File Offset: 0x001DCC50
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x001DEA60 File Offset: 0x001DCC60
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

		// Token: 0x06006A78 RID: 27256 RVA: 0x001DEB2C File Offset: 0x001DCD2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreRewardGainAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005203 RID: 20995
		private int _Result;

		// Token: 0x04005204 RID: 20996
		private int _UnchartedScoreId;

		// Token: 0x04005205 RID: 20997
		private int _score;

		// Token: 0x04005206 RID: 20998
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04005207 RID: 20999
		private IExtension extensionObject;

		// Token: 0x04005208 RID: 21000
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005209 RID: 21001
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400520A RID: 21002
		private LuaFunction m_ctor_hotfix;
	}
}
