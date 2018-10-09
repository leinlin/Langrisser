using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000639 RID: 1593
	[ProtoContract(Name = "HeroCommentReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroCommentReq : IExtensible
	{
		// Token: 0x06005734 RID: 22324 RVA: 0x00197A94 File Offset: 0x00195C94
		public HeroCommentReq()
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

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x00197AFC File Offset: 0x00195CFC
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x00197B04 File Offset: 0x00195D04
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06005737 RID: 22327 RVA: 0x00197B10 File Offset: 0x00195D10
		// (set) Token: 0x06005738 RID: 22328 RVA: 0x00197B18 File Offset: 0x00195D18
		[ProtoMember(2, IsRequired = true, Name = "content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._content;
			}
			set
			{
				this._content = value;
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x00197B24 File Offset: 0x00195D24
		// (set) Token: 0x0600573A RID: 22330 RVA: 0x00197B2C File Offset: 0x00195D2C
		[ProtoMember(3, IsRequired = true, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x00197B38 File Offset: 0x00195D38
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00197B48 File Offset: 0x00195D48
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

		// Token: 0x0600573D RID: 22333 RVA: 0x00197C14 File Offset: 0x00195E14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004183 RID: 16771
		private int _HeroId;

		// Token: 0x04004184 RID: 16772
		private string _content;

		// Token: 0x04004185 RID: 16773
		private long _LastUpdateTime;

		// Token: 0x04004186 RID: 16774
		private IExtension extensionObject;

		// Token: 0x04004187 RID: 16775
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004188 RID: 16776
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004189 RID: 16777
		private LuaFunction m_ctor_hotfix;
	}
}
