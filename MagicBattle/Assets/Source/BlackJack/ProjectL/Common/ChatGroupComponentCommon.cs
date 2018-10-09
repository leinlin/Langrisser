using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000438 RID: 1080
	[HotFix]
	public class ChatGroupComponentCommon : IComponentBase
	{
		// Token: 0x06003F4C RID: 16204 RVA: 0x00124EFC File Offset: 0x001230FC
		public ChatGroupComponentCommon()
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

		// Token: 0x06003F4D RID: 16205 RVA: 0x00124F64 File Offset: 0x00123164
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "ChatGroup";
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x00124FD8 File Offset: 0x001231D8
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00125038 File Offset: 0x00123238
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00125098 File Offset: 0x00123298
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x001250F8 File Offset: 0x001232F8
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x00125168 File Offset: 0x00123368
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x001251E8 File Offset: 0x001233E8
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00125258 File Offset: 0x00123458
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x001252B8 File Offset: 0x001234B8
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x0012532C File Offset: 0x0012352C
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x001253A4 File Offset: 0x001235A4
		// (set) Token: 0x06003F58 RID: 16216 RVA: 0x001253C4 File Offset: 0x001235C4
		[DoNotToLua]
		public ChatGroupComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatGroupComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x001253D0 File Offset: 0x001235D0
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00125598 File Offset: 0x00123798
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002FC9 RID: 12233
		[DoNotToLua]
		private ChatGroupComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002FCA RID: 12234
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002FCB RID: 12235
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002FCC RID: 12236
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002FCD RID: 12237
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002FCE RID: 12238
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002FCF RID: 12239
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002FD0 RID: 12240
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002FD1 RID: 12241
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002FD2 RID: 12242
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002FD3 RID: 12243
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002FD4 RID: 12244
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002FD5 RID: 12245
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04002FD6 RID: 12246
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x02000439 RID: 1081
		public class LuaExportHelper
		{
			// Token: 0x06003F5B RID: 16219 RVA: 0x00125600 File Offset: 0x00123800
			public LuaExportHelper(ChatGroupComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002FD7 RID: 12247
			private ChatGroupComponentCommon m_owner;
		}
	}
}
