using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200073C RID: 1852
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSUnchartedScoreNtf")]
	[Serializable]
	public class DSUnchartedScoreNtf : IExtensible
	{
		// Token: 0x06006166 RID: 24934 RVA: 0x001B6F40 File Offset: 0x001B5140
		public DSUnchartedScoreNtf()
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

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06006167 RID: 24935 RVA: 0x001B6FB4 File Offset: 0x001B51B4
		// (set) Token: 0x06006168 RID: 24936 RVA: 0x001B6FBC File Offset: 0x001B51BC
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06006169 RID: 24937 RVA: 0x001B6FC8 File Offset: 0x001B51C8
		[ProtoMember(2, Name = "UnchartedScores", DataFormat = DataFormat.Default)]
		public List<ProUnchartedScore> UnchartedScores
		{
			get
			{
				return this._UnchartedScores;
			}
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x001B6FD0 File Offset: 0x001B51D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x001B6FE0 File Offset: 0x001B51E0
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

		// Token: 0x0600616C RID: 24940 RVA: 0x001B70AC File Offset: 0x001B52AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSUnchartedScoreNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048F2 RID: 18674
		private uint _Version;

		// Token: 0x040048F3 RID: 18675
		private readonly List<ProUnchartedScore> _UnchartedScores = new List<ProUnchartedScore>();

		// Token: 0x040048F4 RID: 18676
		private IExtension extensionObject;

		// Token: 0x040048F5 RID: 18677
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048F6 RID: 18678
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048F7 RID: 18679
		private LuaFunction m_ctor_hotfix;
	}
}
