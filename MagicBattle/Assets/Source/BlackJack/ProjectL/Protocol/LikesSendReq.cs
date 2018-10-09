using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D9 RID: 1753
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LikesSendReq")]
	[Serializable]
	public class LikesSendReq : IExtensible
	{
		// Token: 0x06005E08 RID: 24072 RVA: 0x001AB590 File Offset: 0x001A9790
		public LikesSendReq()
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

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x001AB5F8 File Offset: 0x001A97F8
		// (set) Token: 0x06005E0A RID: 24074 RVA: 0x001AB600 File Offset: 0x001A9800
		[ProtoMember(1, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x001AB60C File Offset: 0x001A980C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x001AB61C File Offset: 0x001A981C
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

		// Token: 0x06005E0D RID: 24077 RVA: 0x001AB6E8 File Offset: 0x001A98E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LikesSendReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004663 RID: 18019
		private string _TargetUserId;

		// Token: 0x04004664 RID: 18020
		private IExtension extensionObject;

		// Token: 0x04004665 RID: 18021
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004666 RID: 18022
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004667 RID: 18023
		private LuaFunction m_ctor_hotfix;
	}
}
