using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000818 RID: 2072
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RiftLevelAttackReq")]
	[Serializable]
	public class RiftLevelAttackReq : IExtensible
	{
		// Token: 0x0600687E RID: 26750 RVA: 0x001D7934 File Offset: 0x001D5B34
		public RiftLevelAttackReq()
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

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x0600687F RID: 26751 RVA: 0x001D799C File Offset: 0x001D5B9C
		// (set) Token: 0x06006880 RID: 26752 RVA: 0x001D79A4 File Offset: 0x001D5BA4
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

		// Token: 0x06006881 RID: 26753 RVA: 0x001D79B0 File Offset: 0x001D5BB0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x001D79C0 File Offset: 0x001D5BC0
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

		// Token: 0x06006883 RID: 26755 RVA: 0x001D7A8C File Offset: 0x001D5C8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005089 RID: 20617
		private int _LevelId;

		// Token: 0x0400508A RID: 20618
		private IExtension extensionObject;

		// Token: 0x0400508B RID: 20619
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400508C RID: 20620
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400508D RID: 20621
		private LuaFunction m_ctor_hotfix;
	}
}
