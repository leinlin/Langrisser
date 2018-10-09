using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000751 RID: 1873
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "NewMarqueeNtf")]
	[Serializable]
	public class NewMarqueeNtf : IExtensible
	{
		// Token: 0x0600620C RID: 25100 RVA: 0x001B95A4 File Offset: 0x001B77A4
		public NewMarqueeNtf()
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

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x001B960C File Offset: 0x001B780C
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x001B9614 File Offset: 0x001B7814
		[ProtoMember(1, IsRequired = true, Name = "MarqueueInfo", DataFormat = DataFormat.Default)]
		public ProMarquee MarqueueInfo
		{
			get
			{
				return this._MarqueueInfo;
			}
			set
			{
				this._MarqueueInfo = value;
			}
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x001B9620 File Offset: 0x001B7820
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x001B9630 File Offset: 0x001B7830
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

		// Token: 0x06006211 RID: 25105 RVA: 0x001B96FC File Offset: 0x001B78FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NewMarqueeNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004970 RID: 18800
		private ProMarquee _MarqueueInfo;

		// Token: 0x04004971 RID: 18801
		private IExtension extensionObject;

		// Token: 0x04004972 RID: 18802
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004973 RID: 18803
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004974 RID: 18804
		private LuaFunction m_ctor_hotfix;
	}
}
