﻿/**
 * Copyright © 2010-2017 Atilika Inc. and contributors (see CONTRIBUTORS.md)
 * 
 * Modifications copyright (C) 2017 - 2018 Anki Universal Team <ankiuniversal@gmail.com>
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPJapaneseDictionary.Kuromoji.Core.Viterbi
{
    public class MultiSearchResult
    {
        private List<LinkedList<ViterbiNode>> tokenizedResults;
        private List<int> costs;

        public int Count { get { return costs.Count; } }

        public MultiSearchResult()
        {
            tokenizedResults = new List<LinkedList<ViterbiNode>>();
            costs = new List<int>();
        }

        public void Add(LinkedList<ViterbiNode> tokenizedResult, int cost)
        {
            tokenizedResults.Add(tokenizedResult);
            costs.Add(cost);
        }

        public LinkedList<ViterbiNode> GetTokenizedResult(int index)
        {
            return tokenizedResults[index];
        }

        public List<LinkedList<ViterbiNode>> GetTokenizedResultsList()
        {
            return tokenizedResults;
        }

        public int GetCost(int index)
        {
            return costs[index];
        }
       
    }
}
