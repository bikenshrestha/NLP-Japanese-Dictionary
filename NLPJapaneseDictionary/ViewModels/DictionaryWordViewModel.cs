﻿/**
 * Copyright © 2017-2018 Anki Universal Team.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.  A copy of the
 * License is distributed with this work in the LICENSE.md file.  You may
 * also obtain a copy of the License from
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using NLPJapaneseDictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NLPJapaneseDictionary.DatabaseTable.NLPJDictCore;
using NLPJapaneseDictionary.Core;
using System.Text.RegularExpressions;

namespace NLPJapaneseDictionary.ViewModels
{
    public class DictionaryWordViewModel
    {        
        public ObservableCollection<DictionaryWordModel> DictionaryWords { get; set; }

        public DictionaryWordViewModel()
        {
            DictionaryWords = new ObservableCollection<DictionaryWordModel>();
        }

        public void AddNewWordList(List<JmdictEntity> entries)
        {
            DictionaryWords.Clear();
            bool isHaveBorder = false;
            foreach (var entry in entries)
            {
                DictionaryWords.Add(new DictionaryWordModel(new JmdictWord(entry), isHaveBorder));
                isHaveBorder = true;
            }
        }
    }
}
