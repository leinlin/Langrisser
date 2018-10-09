using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200066F RID: 1647
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProDanmakuEntry")]
	[Serializable]
	public class ProDanmakuEntry : IExtensible
	{
		// Token: 0x060059CE RID: 22990 RVA: 0x0019E85C File Offset: 0x0019CA5C
		public ProDanmakuEntry()
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

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x060059CF RID: 22991 RVA: 0x0019E8C4 File Offset: 0x0019CAC4
		// (set) Token: 0x060059D0 RID: 22992 RVA: 0x0019E8CC File Offset: 0x0019CACC
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x060059D1 RID: 22993 RVA: 0x0019E8D8 File Offset: 0x0019CAD8
		// (set) Token: 0x060059D2 RID: 22994 RVA: 0x0019E8E0 File Offset: 0x0019CAE0
		[ProtoMember(2, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x0019E8EC File Offset: 0x0019CAEC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x0019E8FC File Offset: 0x0019CAFC
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

		// Token: 0x060059D5 RID: 22997 RVA: 0x0019E9C8 File Offset: 0x0019CBC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProDanmakuEntry));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004353 RID: 17235
		private string _UserId;

		// Token: 0x04004354 RID: 17236
		private string _Content;

		// Token: 0x04004355 RID: 17237
		private IExtension extensionObject;

		// Token: 0x04004356 RID: 17238
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004357 RID: 17239
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004358 RID: 17240
		private LuaFunction m_ctor_hotfix;
	}
}
