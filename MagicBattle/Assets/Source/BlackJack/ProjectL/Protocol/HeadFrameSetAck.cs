using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000705 RID: 1797
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeadFrameSetAck")]
	[Serializable]
	public class HeadFrameSetAck : IExtensible
	{
		// Token: 0x06005F69 RID: 24425 RVA: 0x001B0664 File Offset: 0x001AE864
		public HeadFrameSetAck()
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

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001B06CC File Offset: 0x001AE8CC
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x001B06D4 File Offset: 0x001AE8D4
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x001B06E0 File Offset: 0x001AE8E0
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x001B06E8 File Offset: 0x001AE8E8
		[ProtoMember(2, IsRequired = true, Name = "HeadFrame", DataFormat = DataFormat.TwosComplement)]
		public int HeadFrame
		{
			get
			{
				return this._HeadFrame;
			}
			set
			{
				this._HeadFrame = value;
			}
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x001B06F4 File Offset: 0x001AE8F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x001B0704 File Offset: 0x001AE904
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

		// Token: 0x06005F70 RID: 24432 RVA: 0x001B07D0 File Offset: 0x001AE9D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeadFrameSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400476F RID: 18287
		private int _Result;

		// Token: 0x04004770 RID: 18288
		private int _HeadFrame;

		// Token: 0x04004771 RID: 18289
		private IExtension extensionObject;

		// Token: 0x04004772 RID: 18290
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004773 RID: 18291
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004774 RID: 18292
		private LuaFunction m_ctor_hotfix;
	}
}
