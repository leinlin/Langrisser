using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B6 RID: 1718
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelDanmakuPostReq")]
	[Serializable]
	public class LevelDanmakuPostReq : IExtensible
	{
		// Token: 0x06005D00 RID: 23808 RVA: 0x001A757C File Offset: 0x001A577C
		public LevelDanmakuPostReq()
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

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x001A75F0 File Offset: 0x001A57F0
		// (set) Token: 0x06005D02 RID: 23810 RVA: 0x001A75F8 File Offset: 0x001A57F8
		[ProtoMember(1, IsRequired = true, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GameFunctionTypeId
		{
			get
			{
				return this._GameFunctionTypeId;
			}
			set
			{
				this._GameFunctionTypeId = value;
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06005D03 RID: 23811 RVA: 0x001A7604 File Offset: 0x001A5804
		// (set) Token: 0x06005D04 RID: 23812 RVA: 0x001A760C File Offset: 0x001A580C
		[ProtoMember(2, IsRequired = true, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				this._LocationId = value;
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06005D05 RID: 23813 RVA: 0x001A7618 File Offset: 0x001A5818
		[ProtoMember(3, Name = "Entries", DataFormat = DataFormat.Default)]
		public List<ProPostDanmakuEntry> Entries
		{
			get
			{
				return this._Entries;
			}
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x001A7620 File Offset: 0x001A5820
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x001A7630 File Offset: 0x001A5830
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

		// Token: 0x06005D08 RID: 23816 RVA: 0x001A76FC File Offset: 0x001A58FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelDanmakuPostReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004590 RID: 17808
		private int _GameFunctionTypeId;

		// Token: 0x04004591 RID: 17809
		private int _LocationId;

		// Token: 0x04004592 RID: 17810
		private readonly List<ProPostDanmakuEntry> _Entries = new List<ProPostDanmakuEntry>();

		// Token: 0x04004593 RID: 17811
		private IExtension extensionObject;

		// Token: 0x04004594 RID: 17812
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004595 RID: 17813
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004596 RID: 17814
		private LuaFunction m_ctor_hotfix;
	}
}
