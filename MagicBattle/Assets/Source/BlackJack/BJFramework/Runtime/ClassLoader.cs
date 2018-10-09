using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200002B RID: 43
	public class ClassLoader
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0000D770 File Offset: 0x0000B970
		private ClassLoader()
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000D790 File Offset: 0x0000B990
		public static ClassLoader CreateClassLoader()
		{
			if (ClassLoader.m_instance == null)
			{
				ClassLoader.m_instance = new ClassLoader();
			}
			return ClassLoader.m_instance;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public object CreateInstance(TypeDNName typeDNName, params object[] args)
		{
			Type type = this.LoadType(typeDNName);
			if (type == null)
			{
				return null;
			}
			return Activator.CreateInstance(type, args);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
		public Type LoadType(TypeDNName typeDNName)
		{
			Type type;
			if (!this.m_typeDict.TryGetValue(typeDNName.m_typeFullName, out type))
			{
				Assembly assembly;
				if (string.IsNullOrEmpty(typeDNName.m_assemblyName))
				{
					assembly = this.m_assembleDict["Assembly-CSharp"];
				}
				else if (!this.m_assembleDict.TryGetValue(typeDNName.m_assemblyName, out assembly))
				{
					return null;
				}
				type = assembly.GetType(typeDNName.m_typeFullName);
				if (type == null)
				{
					Debug.LogError(string.Format("Can not find type {0}", typeDNName.m_typeFullName));
					return null;
				}
				this.m_typeDict[typeDNName.m_typeFullName] = type;
			}
			return type;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000D87C File Offset: 0x0000BA7C
		public void AddAssembly(Assembly assembly)
		{
			this.m_assembleDict[assembly.GetName().Name] = assembly;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000D898 File Offset: 0x0000BA98
		public static ClassLoader Instance
		{
			get
			{
				return ClassLoader.m_instance;
			}
		}

		// Token: 0x040000B4 RID: 180
		private static ClassLoader m_instance;

		// Token: 0x040000B5 RID: 181
		private Dictionary<string, Assembly> m_assembleDict = new Dictionary<string, Assembly>();

		// Token: 0x040000B6 RID: 182
		private Dictionary<string, Type> m_typeDict = new Dictionary<string, Type>();
	}
}
