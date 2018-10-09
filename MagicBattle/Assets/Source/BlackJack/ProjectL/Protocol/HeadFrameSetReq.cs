using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000704 RID: 1796
	[ProtoContract(Name = "HeadFrameSetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeadFrameSetReq : IExtensible
	{
		// Token: 0x06005F63 RID: 24419 RVA: 0x001B04A4 File Offset: 0x001AE6A4
		public HeadFrameSetReq()
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

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x001B050C File Offset: 0x001AE70C
		// (set) Token: 0x06005F65 RID: 24421 RVA: 0x001B0514 File Offset: 0x001AE714
		[ProtoMember(1, IsRequired = true, Name = "HeadFrame", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005F66 RID: 24422 RVA: 0x001B0520 File Offset: 0x001AE720
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x001B0530 File Offset: 0x001AE730
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

		// Token: 0x06005F68 RID: 24424 RVA: 0x001B05FC File Offset: 0x001AE7FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeadFrameSetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400476A RID: 18282
		private int _HeadFrame;

		// Token: 0x0400476B RID: 18283
		private IExtension extensionObject;

		// Token: 0x0400476C RID: 18284
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400476D RID: 18285
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400476E RID: 18286
		private LuaFunction m_ctor_hotfix;
	}
}
