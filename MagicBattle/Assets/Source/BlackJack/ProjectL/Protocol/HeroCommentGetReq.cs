using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000637 RID: 1591
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroCommentGetReq")]
	[Serializable]
	public class HeroCommentGetReq : IExtensible
	{
		// Token: 0x06005720 RID: 22304 RVA: 0x001976C4 File Offset: 0x001958C4
		public HeroCommentGetReq()
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

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x0019772C File Offset: 0x0019592C
		// (set) Token: 0x06005722 RID: 22306 RVA: 0x00197734 File Offset: 0x00195934
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

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06005723 RID: 22307 RVA: 0x00197740 File Offset: 0x00195940
		// (set) Token: 0x06005724 RID: 22308 RVA: 0x00197748 File Offset: 0x00195948
		[ProtoMember(2, IsRequired = true, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005725 RID: 22309 RVA: 0x00197754 File Offset: 0x00195954
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00197764 File Offset: 0x00195964
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

		// Token: 0x06005727 RID: 22311 RVA: 0x00197830 File Offset: 0x00195A30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004175 RID: 16757
		private int _HeroId;

		// Token: 0x04004176 RID: 16758
		private long _LastUpdateTime;

		// Token: 0x04004177 RID: 16759
		private IExtension extensionObject;

		// Token: 0x04004178 RID: 16760
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004179 RID: 16761
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400417A RID: 16762
		private LuaFunction m_ctor_hotfix;
	}
}
