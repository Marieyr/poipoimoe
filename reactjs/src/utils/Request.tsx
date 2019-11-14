import axios from 'axios';

export default (url, params) => {
  axios({
    url: url,
    method: 'GET',
    ...params,
  });
};
