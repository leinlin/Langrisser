using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007CD RID: 1997
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ModelSkinTakeOffReq")]
	[Serializable]
	public class ModelSkinTakeOffReq : IExtensible
	{
		// Token: 0x06006608 RID: 26120 RVA: 0x001C7A48 File Offset: 0x001C5C48
		public ModelSkinTakeOffReq()
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

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06006609 RID: 26121 RVA: 0x001C7AB0 File Offset: 0x001C5CB0
		// (set) Token: 0x0600660A RID: 26122 RVA: 0x001C7AB8 File Offset: 0x001C5CB8
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

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x001C7AC4 File Offset: 0x001C5CC4
		// (set) Token: 0x0600660C RID: 26124 RVA: 0x001C7ACC File Offset: 0x001C5CCC
		[ProtoMember(2, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x001C7AD8 File Offset: 0x001C5CD8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x001C7AE8 File Offset: 0x001C5CE8
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

		// Token: 0x0600660F RID: 26127 RVA: 0x001C7BB4 File Offset: 0x001C5DB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ModelSkinTakeOffReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C70 RID: 19568
		private int _HeroId;

		// Token: 0x04004C71 RID: 19569
		private int _JobRelatedId;

		// Token: 0x04004C72 RID: 19570
		private IExtension extensionObject;

		// Token: 0x04004C73 RID: 19571
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C74 RID: 19572
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C75 RID: 19573
		private LuaFunction m_ctor_hotfix;
	}
}
