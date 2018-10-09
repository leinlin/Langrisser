using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007DF RID: 2015
	[ProtoContract(Name = "RandomEventNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RandomEventNtf : IExtensible
	{
		// Token: 0x060066B8 RID: 26296 RVA: 0x001C9CA4 File Offset: 0x001C7EA4
		public RandomEventNtf()
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

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x060066B9 RID: 26297 RVA: 0x001C9D0C File Offset: 0x001C7F0C
		// (set) Token: 0x060066BA RID: 26298 RVA: 0x001C9D14 File Offset: 0x001C7F14
		[ProtoMember(1, IsRequired = true, Name = "RandomEventInfo", DataFormat = DataFormat.Default)]
		public ProRandomEvent RandomEventInfo
		{
			get
			{
				return this._RandomEventInfo;
			}
			set
			{
				this._RandomEventInfo = value;
			}
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x001C9D20 File Offset: 0x001C7F20
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x001C9D30 File Offset: 0x001C7F30
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

		// Token: 0x060066BD RID: 26301 RVA: 0x001C9DFC File Offset: 0x001C7FFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomEventNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CEF RID: 19695
		private ProRandomEvent _RandomEventInfo;

		// Token: 0x04004CF0 RID: 19696
		private IExtension extensionObject;

		// Token: 0x04004CF1 RID: 19697
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CF2 RID: 19698
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CF3 RID: 19699
		private LuaFunction m_ctor_hotfix;
	}
}
