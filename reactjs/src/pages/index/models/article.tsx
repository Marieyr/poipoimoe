
export default {
    namespace: 'articles',
    state: {
      articleList:[]
    },
    reducers: {
      getArticles(state,action){
        console.log(state)
        console.log(action)
        return {...state,...action.payload};
      }
    },
    effects:{
      getArticles({payload={}},{call,put})
      {
        return put({
          type:'getArticle',
          payload:{
            articleList:[{title:'11111111111'}]
          }

        })
      }
    },
    subscriptions:{
      loading({dispatch,history})
      {
        return history.listen(({pathname})=>{
          if(pathname==='/')
          {
            dispatch({
              type:'getArticles'
            })
          }
        })
      }
    }

  };
