using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ies.Logo.Core.Configuration
{
    /// <summary>
    /// Multi-result-set okuyucu. Birden çok SELECT içeren bir SQL'in dönen her result set'ini sırayla veya indeksle typed olarak çekmek için kullanılır.
    ///
    /// İki kullanım modu:
    /// <list type="bullet">
    ///   <item><see cref="Read{T}()"/> — cursor sırayla ilerler; SQL'deki SELECT sırasıyla aynı sırada çağrılmalı.</item>
    ///   <item><see cref="Read{T}(int)"/> — explicit index; sıra önemsiz, aynı set'i birden çok kez okuma da mümkün.</item>
    /// </list>
    /// Tek satırlı sorgularda <c>reader.Read&lt;T&gt;().FirstOrDefault()</c> kullanın.
    /// </summary>
    public class MultipleQueryReader
    {
        private readonly IReadOnlyList<string> _raw;
        private int _cursor;

        public MultipleQueryReader(IReadOnlyList<string> raw)
        {
            _raw = raw ?? throw new ArgumentNullException(nameof(raw));
        }

        public int Count => _raw.Count;

        /// <summary>Sıradaki result set'i T listesine deserialize eder ve cursor'ı ilerletir.</summary>
        public List<T> Read<T>()
        {
            if (_cursor >= _raw.Count)
                throw new InvalidOperationException(
                    $"No more result sets — SQL {_raw.Count} adet SELECT döndürdü, Read() {_cursor + 1}. kez çağrıldı.");
            return DeserializeAt<T>(_cursor++);
        }

        /// <summary>Belirtilen indekste yer alan result set'i T listesine deserialize eder. Cursor'ı etkilemez.</summary>
        public List<T> Read<T>(int index)
        {
            if (index < 0 || index >= _raw.Count)
                throw new ArgumentOutOfRangeException(nameof(index),
                    $"Geçersiz index {index} — SQL {_raw.Count} adet SELECT döndürdü.");
            return DeserializeAt<T>(index);
        }

        private List<T> DeserializeAt<T>(int index)
        {
            var json = _raw[index];
            if (string.IsNullOrWhiteSpace(json)) return new List<T>();
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }
    }
}
