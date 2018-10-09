using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007BA RID: 1978
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentTakeOffAck")]
	[Serializable]
	public class EquipmentTakeOffAck : IExtensible
	{
		// Token: 0x06006551 RID: 25937 RVA: 0x001C564C File Offset: 0x001C384C
		public EquipmentTakeOffAck()
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

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06006552 RID: 25938 RVA: 0x001C56B4 File Offset: 0x001C38B4
		// (set) Token: 0x06006553 RID: 25939 RVA: 0x001C56BC File Offset: 0x001C38BC
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

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x001C56C8 File Offset: 0x001C38C8
		// (set) Token: 0x06006555 RID: 25941 RVA: 0x001C56D0 File Offset: 0x001C38D0
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x001C56DC File Offset: 0x001C38DC
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x001C56E4 File Offset: 0x001C38E4
		[ProtoMember(3, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x001C56F0 File Offset: 0x001C38F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x001C5700 File Offset: 0x001C3900
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

		// Token: 0x0600655A RID: 25946 RVA: 0x001C57CC File Offset: 0x001C39CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentTakeOffAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BEE RID: 19438
		private int _Result;

		// Token: 0x04004BEF RID: 19439
		private int _HeroId;

		// Token: 0x04004BF0 RID: 19440
		private int _Slot;

		// Token: 0x04004BF1 RID: 19441
		private IExtension extensionObject;

		// Token: 0x04004BF2 RID: 19442
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BF3 RID: 19443
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BF4 RID: 19444
		private LuaFunction m_ctor_hotfix;
	}
}
