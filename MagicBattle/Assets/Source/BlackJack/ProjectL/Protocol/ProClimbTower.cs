using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A8 RID: 1704
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProClimbTower")]
	[Serializable]
	public class ProClimbTower : IExtensible
	{
		// Token: 0x06005C76 RID: 23670 RVA: 0x001A5A88 File Offset: 0x001A3C88
		public ProClimbTower()
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

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06005C77 RID: 23671 RVA: 0x001A5AFC File Offset: 0x001A3CFC
		[ProtoMember(1, Name = "Floors", DataFormat = DataFormat.Default)]
		public List<ProClimbTowerFloor> Floors
		{
			get
			{
				return this._Floors;
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06005C78 RID: 23672 RVA: 0x001A5B04 File Offset: 0x001A3D04
		// (set) Token: 0x06005C79 RID: 23673 RVA: 0x001A5B0C File Offset: 0x001A3D0C
		[ProtoMember(2, IsRequired = true, Name = "NextFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFlushTime
		{
			get
			{
				return this._NextFlushTime;
			}
			set
			{
				this._NextFlushTime = value;
			}
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x001A5B18 File Offset: 0x001A3D18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x001A5B28 File Offset: 0x001A3D28
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

		// Token: 0x06005C7C RID: 23676 RVA: 0x001A5BF4 File Offset: 0x001A3DF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProClimbTower));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400452A RID: 17706
		private readonly List<ProClimbTowerFloor> _Floors = new List<ProClimbTowerFloor>();

		// Token: 0x0400452B RID: 17707
		private long _NextFlushTime;

		// Token: 0x0400452C RID: 17708
		private IExtension extensionObject;

		// Token: 0x0400452D RID: 17709
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400452E RID: 17710
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400452F RID: 17711
		private LuaFunction m_ctor_hotfix;
	}
}
