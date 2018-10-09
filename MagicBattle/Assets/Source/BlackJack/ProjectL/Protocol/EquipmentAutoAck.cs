using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007BC RID: 1980
	[ProtoContract(Name = "EquipmentAutoAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class EquipmentAutoAck : IExtensible
	{
		// Token: 0x06006561 RID: 25953 RVA: 0x001C59F4 File Offset: 0x001C3BF4
		public EquipmentAutoAck()
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

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x001C5A68 File Offset: 0x001C3C68
		// (set) Token: 0x06006563 RID: 25955 RVA: 0x001C5A70 File Offset: 0x001C3C70
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

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06006564 RID: 25956 RVA: 0x001C5A7C File Offset: 0x001C3C7C
		// (set) Token: 0x06006565 RID: 25957 RVA: 0x001C5A84 File Offset: 0x001C3C84
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

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06006566 RID: 25958 RVA: 0x001C5A90 File Offset: 0x001C3C90
		[ProtoMember(3, Name = "EquipmentInstanceIds", DataFormat = DataFormat.TwosComplement)]
		public List<ulong> EquipmentInstanceIds
		{
			get
			{
				return this._EquipmentInstanceIds;
			}
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x001C5A98 File Offset: 0x001C3C98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x001C5AA8 File Offset: 0x001C3CA8
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

		// Token: 0x06006569 RID: 25961 RVA: 0x001C5B74 File Offset: 0x001C3D74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentAutoAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BFA RID: 19450
		private int _Result;

		// Token: 0x04004BFB RID: 19451
		private int _HeroId;

		// Token: 0x04004BFC RID: 19452
		private readonly List<ulong> _EquipmentInstanceIds = new List<ulong>();

		// Token: 0x04004BFD RID: 19453
		private IExtension extensionObject;

		// Token: 0x04004BFE RID: 19454
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BFF RID: 19455
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C00 RID: 19456
		private LuaFunction m_ctor_hotfix;
	}
}
