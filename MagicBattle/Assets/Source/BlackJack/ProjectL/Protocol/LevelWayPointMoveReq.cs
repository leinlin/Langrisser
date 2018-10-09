using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007DB RID: 2011
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelWayPointMoveReq")]
	[Serializable]
	public class LevelWayPointMoveReq : IExtensible
	{
		// Token: 0x0600668D RID: 26253 RVA: 0x001C94CC File Offset: 0x001C76CC
		public LevelWayPointMoveReq()
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

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x001C9534 File Offset: 0x001C7734
		// (set) Token: 0x0600668F RID: 26255 RVA: 0x001C953C File Offset: 0x001C773C
		[ProtoMember(1, IsRequired = true, Name = "WayPointId", DataFormat = DataFormat.TwosComplement)]
		public int WayPointId
		{
			get
			{
				return this._WayPointId;
			}
			set
			{
				this._WayPointId = value;
			}
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x001C9548 File Offset: 0x001C7748
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x001C9558 File Offset: 0x001C7758
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

		// Token: 0x06006692 RID: 26258 RVA: 0x001C9624 File Offset: 0x001C7824
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelWayPointMoveReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CD0 RID: 19664
		private int _WayPointId;

		// Token: 0x04004CD1 RID: 19665
		private IExtension extensionObject;

		// Token: 0x04004CD2 RID: 19666
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CD3 RID: 19667
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CD4 RID: 19668
		private LuaFunction m_ctor_hotfix;
	}
}
