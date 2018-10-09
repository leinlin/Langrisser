using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200084F RID: 2127
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TrainingGroundTechLevelupAck")]
	[Serializable]
	public class TrainingGroundTechLevelupAck : IExtensible
	{
		// Token: 0x06006A35 RID: 27189 RVA: 0x001DDE40 File Offset: 0x001DC040
		public TrainingGroundTechLevelupAck()
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

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06006A36 RID: 27190 RVA: 0x001DDEA8 File Offset: 0x001DC0A8
		// (set) Token: 0x06006A37 RID: 27191 RVA: 0x001DDEB0 File Offset: 0x001DC0B0
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

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x001DDEBC File Offset: 0x001DC0BC
		// (set) Token: 0x06006A39 RID: 27193 RVA: 0x001DDEC4 File Offset: 0x001DC0C4
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public TrainingGroundTechLevelupReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x001DDED0 File Offset: 0x001DC0D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x001DDEE0 File Offset: 0x001DC0E0
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

		// Token: 0x06006A3C RID: 27196 RVA: 0x001DDFAC File Offset: 0x001DC1AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingGroundTechLevelupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051DA RID: 20954
		private int _Result;

		// Token: 0x040051DB RID: 20955
		private TrainingGroundTechLevelupReq _Req;

		// Token: 0x040051DC RID: 20956
		private IExtension extensionObject;

		// Token: 0x040051DD RID: 20957
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051DE RID: 20958
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051DF RID: 20959
		private LuaFunction m_ctor_hotfix;
	}
}
