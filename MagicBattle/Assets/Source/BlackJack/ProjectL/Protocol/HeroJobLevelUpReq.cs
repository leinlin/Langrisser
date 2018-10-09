using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A9 RID: 1961
	[ProtoContract(Name = "HeroJobLevelUpReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroJobLevelUpReq : IExtensible
	{
		// Token: 0x060064B9 RID: 25785 RVA: 0x001C3684 File Offset: 0x001C1884
		public HeroJobLevelUpReq()
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

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x060064BA RID: 25786 RVA: 0x001C36EC File Offset: 0x001C18EC
		// (set) Token: 0x060064BB RID: 25787 RVA: 0x001C36F4 File Offset: 0x001C18F4
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

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x001C3700 File Offset: 0x001C1900
		// (set) Token: 0x060064BD RID: 25789 RVA: 0x001C3708 File Offset: 0x001C1908
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

		// Token: 0x060064BE RID: 25790 RVA: 0x001C3714 File Offset: 0x001C1914
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x001C3724 File Offset: 0x001C1924
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

		// Token: 0x060064C0 RID: 25792 RVA: 0x001C37F0 File Offset: 0x001C19F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobLevelUpReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B7F RID: 19327
		private int _HeroId;

		// Token: 0x04004B80 RID: 19328
		private int _JobRelatedId;

		// Token: 0x04004B81 RID: 19329
		private IExtension extensionObject;

		// Token: 0x04004B82 RID: 19330
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B83 RID: 19331
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B84 RID: 19332
		private LuaFunction m_ctor_hotfix;
	}
}
