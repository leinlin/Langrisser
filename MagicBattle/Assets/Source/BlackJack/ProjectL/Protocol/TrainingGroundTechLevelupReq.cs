using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200084E RID: 2126
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TrainingGroundTechLevelupReq")]
	[Serializable]
	public class TrainingGroundTechLevelupReq : IExtensible
	{
		// Token: 0x06006A2D RID: 27181 RVA: 0x001DDC6C File Offset: 0x001DBE6C
		public TrainingGroundTechLevelupReq()
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

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x001DDCD4 File Offset: 0x001DBED4
		// (set) Token: 0x06006A2F RID: 27183 RVA: 0x001DDCDC File Offset: 0x001DBEDC
		[ProtoMember(1, IsRequired = true, Name = "TechId", DataFormat = DataFormat.TwosComplement)]
		public int TechId
		{
			get
			{
				return this._TechId;
			}
			set
			{
				this._TechId = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06006A30 RID: 27184 RVA: 0x001DDCE8 File Offset: 0x001DBEE8
		// (set) Token: 0x06006A31 RID: 27185 RVA: 0x001DDCF0 File Offset: 0x001DBEF0
		[DefaultValue(0)]
		[ProtoMember(2, IsRequired = false, Name = "DeltaLevel", DataFormat = DataFormat.TwosComplement)]
		public int DeltaLevel
		{
			get
			{
				return this._DeltaLevel;
			}
			set
			{
				this._DeltaLevel = value;
			}
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x001DDCFC File Offset: 0x001DBEFC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x001DDD0C File Offset: 0x001DBF0C
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

		// Token: 0x06006A34 RID: 27188 RVA: 0x001DDDD8 File Offset: 0x001DBFD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingGroundTechLevelupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051D4 RID: 20948
		private int _TechId;

		// Token: 0x040051D5 RID: 20949
		private int _DeltaLevel;

		// Token: 0x040051D6 RID: 20950
		private IExtension extensionObject;

		// Token: 0x040051D7 RID: 20951
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051D8 RID: 20952
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051D9 RID: 20953
		private LuaFunction m_ctor_hotfix;
	}
}
