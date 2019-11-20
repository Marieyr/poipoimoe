
import {GetArticleList} from '../service/api'

export default {
    namespace: 'articles',
    state: {
      articleList:[]
    },
    reducers: {
      getArticles(state,action){
        return {...state,...action.payload};
      }
    },
    effects:{
      *getArticles({payload={}},{call,put})
      {

        const res=yield call(GetArticleList,payload);
        yield put({
          type:'getArticles',
          payload:{
            articleList:res.data
          }

        })
      }
    },
    subscriptions:{
      loading({dispatch,history})
      {
        return history.listen(({pathname,query})=>{
          if(pathname==='/')
          {
            dispatch({
              type:'getArticles',
              payload:query
            })
          }
        })
      }
    }

  };
